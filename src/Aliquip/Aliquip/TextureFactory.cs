﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Silk.NET.Vulkan;
using Silk.NET.Vulkan.VMA;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Image = Silk.NET.Vulkan.Image;

namespace Aliquip
{
    internal sealed class TextureFactory : ITextureFactory, IDisposable
    {
        private readonly Vk _vk;
        private readonly ITransferQueueProvider _transferQueueProvider;
        private readonly IResourceProvider _resourceProvider;
        private readonly ILogicalDeviceProvider _logicalDeviceProvider;
        private readonly IBufferFactory _bufferFactory;
        private readonly IPhysicalDeviceProvider _physicalDeviceProvider;
        private readonly ICommandBufferFactory _commandBufferFactory;
        private readonly IGraphicsQueueProvider _graphicsQueueProvider;
        private readonly Vma _vma;
        private readonly IAllocatorProvider _allocatorProvider;
        private readonly Dictionary<string, Texture> _cache = new();
        public Texture this[string name]
        {
            get
            {
                if (_cache.TryGetValue(name, out var t))
                    return t;
                
                t = CreateImage(SixLabors.ImageSharp.Image.Load(_resourceProvider["textures." + name]), true, true, SampleCountFlags.SampleCount1Bit, ImageAspectFlags.ImageAspectColorBit);
                _cache[name] = t;
                return t;
            }
        }

        public TextureFactory
        (
            Vk vk,
            ITransferQueueProvider transferQueueProvider,
            IResourceProvider resourceProvider,
            ILogicalDeviceProvider logicalDeviceProvider,
            IBufferFactory bufferFactory,
            IPhysicalDeviceProvider physicalDeviceProvider,
            ICommandBufferFactory commandBufferFactory,
            IGraphicsQueueProvider graphicsQueueProvider,
            Vma vma,
            IAllocatorProvider allocatorProvider
        )
        {
            _vk = vk;
            _transferQueueProvider = transferQueueProvider;
            _resourceProvider = resourceProvider;
            _logicalDeviceProvider = logicalDeviceProvider;
            _bufferFactory = bufferFactory;
            _physicalDeviceProvider = physicalDeviceProvider;
            _commandBufferFactory = commandBufferFactory;
            _graphicsQueueProvider = graphicsQueueProvider;
            _vma = vma;
            _allocatorProvider = allocatorProvider;
        }

        public unsafe Texture CreateImage(Image<Rgba32> src, bool createSampler, bool useMipmaps, SampleCountFlags numSamples, ImageAspectFlags aspectFlags, ImageUsageFlags imageUsageFlags = default)
        {
            var texture = new Texture
            (
                (uint) src.Width, (uint) src.Height, Format.R8G8B8A8Srgb, numSamples, _vk, _commandBufferFactory,
                _transferQueueProvider, _logicalDeviceProvider, _physicalDeviceProvider, _graphicsQueueProvider,
                _bufferFactory, _allocatorProvider, _vma, createSampler, useMipmaps, aspectFlags,
                imageUsageFlags | ImageUsageFlags.ImageUsageTransferDstBit | ImageUsageFlags.ImageUsageSampledBit |
                ImageUsageFlags.ImageUsageTransferSrcBit
            );
            
            var pixelCount = src.Width * src.Height;
            var totalImageSize = pixelCount * 4;
            var (stagingBuffer, allocation, allocationInfo) = _bufferFactory.CreateBuffer
            (
                (ulong) totalImageSize, MemoryUsage.MemoryUsageCpuToGpu, BufferUsageFlags.BufferUsageTransferSrcBit,
                MemoryPropertyFlags.MemoryPropertyHostVisibleBit | MemoryPropertyFlags.MemoryPropertyHostCoherentBit,
                stackalloc[] {_transferQueueProvider.TransferQueueIndex, _graphicsQueueProvider.GraphicsQueueIndex}, AllocationCreateFlagBits.AllocationCreateMappedBit
            );

            void* data = allocationInfo.PMappedData;
            
            var s = new Span<Rgba32>(data, pixelCount);
            if (src.TryGetSinglePixelSpan(out var s2))
                s2.CopyTo(s);
            else
            {
                for (int r = 0; r < src.Height; r++)
                {
                    s2 = src.GetPixelRowSpan(r);
                    s2.CopyTo(s.Slice(r * pixelCount, src.Width));
                }
            }

            var allocator = _allocatorProvider.Allocator;
            _vma.UnmapMemory(&allocator, &allocation);
            
            texture.TransitionImageLayout(ImageLayout.TransferDstOptimal);
            texture.CopyBufferToImage(stagingBuffer);
            _vma.DestroyBuffer(&allocator, stagingBuffer.Handle, &allocation);
            // implicitly transitions to ShaderReadOnlyOptimal
            texture.GenerateMipmaps();
            
            return texture;
        }
        
        public Texture CreateImage
            (uint width, uint height, Format format, bool createSampler, bool useMipmaps, SampleCountFlags numSamples, ImageAspectFlags aspectFlags, ImageUsageFlags imageUsageFlags)
        {
            return new
            (
                width, height, format, numSamples, _vk, _commandBufferFactory, _transferQueueProvider,
                _logicalDeviceProvider, _physicalDeviceProvider, _graphicsQueueProvider, _bufferFactory, _allocatorProvider, _vma,
                createSampler, useMipmaps, aspectFlags, imageUsageFlags
            );
        }

        public void Dispose()
        {
            foreach (var texture in _cache)
            {
                texture.Value.Dispose();
            }
            
            _cache.Clear();
        }
    }
}
