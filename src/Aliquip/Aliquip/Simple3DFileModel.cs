﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using ObjLoader.Loader.Loaders;
using Silk.NET.Maths;

namespace Aliquip
{
    internal sealed class Simple3DFileModel : IModel
    {
        private static readonly Dictionary<string, Simple3DFileModel> _cache = new();

        public static Simple3DFileModel Create(string fileName, IResourceProvider resourceProvider, ILogger<Simple3DFileModel> logger)
        {
            if (_cache.TryGetValue(fileName, out var v))
                return v;

            v = new Simple3DFileModel(fileName, resourceProvider, logger);
            _cache[fileName] = v;
            return v;
        }
        
        public int VertexCount => Vertices.Length;
        public unsafe int VertexSize => sizeof(Vertex);
        public int IndexCount => Indices.Length;

        ReadOnlySpan<byte> IModel.Vertices => MemoryMarshal.Cast<Vertex, byte>(Vertices.AsSpan());

        ReadOnlySpan<uint> IModel.Indices => Indices;

        public Vertex[] Vertices { get; } 
        //     =
        // {
        //     new(new(-0.5f, -0.5f, 0.0f), new(1.0f, 0.0f, 0.0f), new(1.0f, 0.0f)),
        //     new(new(0.5f, -0.5f, 0.0f), new(0.0f, 1.0f, 0.0f), new(0.0f, 0.0f)),
        //     new(new(0.5f, 0.5f, 0.0f), new(0.0f, 0.0f, 1.0f), new(0.0f, 1.0f)),
        //     new(new(-0.5f, 0.5f, 0.0f), new(1.0f, 1.0f, 1.0f), new(1.0f, 1.0f)),
        // 
        //     new(new(-0.5f, -0.5f, -0.5f), new(1.0f, 0.0f, 0.0f), new(1.0f, 0.0f)),
        //     new(new(0.5f, -0.5f, -0.5f), new(0.0f, 1.0f, 0.0f), new(0.0f, 0.0f)),
        //     new(new(0.5f, 0.5f, -0.5f), new(0.0f, 0.0f, 1.0f), new(0.0f, 1.0f)),
        //     new(new(-0.5f, 0.5f, -0.5f), new(1.0f, 1.0f, 1.0f), new(1.0f, 1.0f)),
        // };

        public uint[] Indices { get; } 
        //     =
        // {
        //     0, 1, 2, 2, 3, 0,
        //     4, 5, 6, 6, 7, 4
        // };
        
        private class ResourceMaterialLoader : IMaterialStreamProvider
        {
            private IResourceProvider _resourceProvider;

            public ResourceMaterialLoader(IResourceProvider resourceProvider)
            {
                _resourceProvider = resourceProvider;
            }
            
            public Stream Open(string materialFilePath)
            {
                return new MemoryStream(_resourceProvider[materialFilePath]);
            }
        }

        private Simple3DFileModel(string fileName, IResourceProvider resourceProvider, ILogger<Simple3DFileModel> logger)
        {
            var objLoaderFactory = new ObjLoaderFactory();
            // var objLoader = objLoaderFactory.Create(new ResourceMaterialLoader(resourceProvider));
            var objLoader = objLoaderFactory.Create(new MaterialNullStreamProvider());
            using var stream = new MemoryStream(resourceProvider["models." + fileName + ".obj"]);
            var result = objLoader.Load(stream);

            var vertices = new List<Vertex>();
            var indices = new List<uint>();
            foreach (var group in result.Groups)
            {
                foreach (var face in group.Faces)
                {
                    for (int i = 0; i < face.Count; i++)
                    {
                        try
                        {
                            var pos = result.Vertices[face[i].VertexIndex - 1];
                            var texture = result.Textures[face[i].TextureIndex - 1];
                            vertices.Add
                            (
                                new Vertex
                                (
                                    new Vector3D<float>(pos.X, pos.Y, pos.Z), new Vector3D<float>(1, 1, 1),
                                    new Vector2D<float>(texture.X, 1.0f - texture.Y)
                                )
                            );
                            indices.Add((uint) indices.Count);
                        }
                        catch (Exception ex)
                        {
                            Debugger.Break();
                            throw;
                        }
                    }
                }
            }

            Vertices = vertices.ToArray();
            Indices = indices.ToArray();
            logger.LogInformation("Loaded Model. {vertices} vertices and {indices} indices.", vertices.Count, indices.Count);
        }
    }
}