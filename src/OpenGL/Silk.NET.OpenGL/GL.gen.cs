// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public unsafe partial class GL : NativeAPI
    {

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public unsafe partial void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public partial void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public partial void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPolygonOffsetClamp")]
        public partial void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp);

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] byte* pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] Span<byte> pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public unsafe partial void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectCount")]
        public partial void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public unsafe partial void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectCount")]
        public partial void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public unsafe partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] uint* pConstantIndex, [Flow(FlowDirection.In)] uint* pConstantValue);

        [NativeApi(EntryPoint = "glSpecializeShader")]
        public partial void SpecializeShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] string pEntryPoint, [Flow(FlowDirection.In)] uint numSpecializationConstants, [Flow(FlowDirection.In)] Span<uint> pConstantIndex, [Flow(FlowDirection.In)] Span<uint> pConstantValue);

        [NativeApi(EntryPoint = "glBindTextureUnit")]
        public partial void BindTextureUnit([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public partial void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public partial GLEnum CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public unsafe partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public unsafe partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public unsafe partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClipControl")]
        public partial void ClipControl([Flow(FlowDirection.In)] GLEnum origin, [Flow(FlowDirection.In)] GLEnum depth);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public unsafe partial void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public unsafe partial void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public unsafe partial void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyNamedBufferSubData")]
        public partial void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyTextureSubImage1D")]
        public partial void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTextureSubImage2D")]
        public partial void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTextureSubImage3D")]
        public partial void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCreateBuffers")]
        public unsafe partial void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glCreateBuffers")]
        public partial void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public unsafe partial void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public partial void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public unsafe partial void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public partial void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public unsafe partial void CreateQueries([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public partial void CreateQueries([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public unsafe partial void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public partial void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glCreateSamplers")]
        public unsafe partial void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glCreateSamplers")]
        public partial void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public unsafe partial void CreateTextures([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public partial void CreateTextures([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public unsafe partial void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public partial void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public unsafe partial void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public partial void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib")]
        public partial void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib")]
        public partial void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange")]
        public partial void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glGenerateTextureMipmap")]
        public partial void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public unsafe partial void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public partial void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public unsafe partial void GetCompressedTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetCompressedTextureSubImage")]
        public partial void GetCompressedTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetGraphicsResetStatus")]
        public partial GLEnum GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public unsafe partial void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public unsafe partial void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public partial void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public unsafe partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public partial void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public partial void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<double> v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public partial void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public partial void GetnMap([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<int> v);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] GLEnum map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<ushort> values);

        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public unsafe partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] byte* pattern);

        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<byte> pattern);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] void* column, [Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] Span<T1> column, [Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnUniformdv")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetnUniformdv")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public partial void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public unsafe partial void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public partial void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public unsafe partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public unsafe partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public unsafe partial void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public partial void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public unsafe partial void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public partial void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public unsafe partial void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public partial void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public unsafe partial void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public partial void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public unsafe partial void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] GLEnum* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public partial void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<GLEnum> attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public unsafe partial void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public partial void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public unsafe partial void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum access);

        [NativeApi(EntryPoint = "glMapNamedBufferRange")]
        public unsafe partial void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMemoryBarrierByRegion")]
        public partial void MemoryBarrierByRegion([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public unsafe partial void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public partial void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public unsafe partial void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public partial void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public unsafe partial void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public partial void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public partial void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public unsafe partial void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] GLEnum* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public partial void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<GLEnum> bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public partial void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public partial void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public partial void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public partial void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public partial void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public partial void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureBarrier")]
        public partial void TextureBarrier();

        [NativeApi(EntryPoint = "glTextureBuffer")]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTextureParameterf")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<float> param);

        [NativeApi(EntryPoint = "glTextureParameteri")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<int> param);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public partial void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public partial void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public partial void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase")]
        public partial void TransformFeedbackBufferBase([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange")]
        public partial void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glUnmapNamedBuffer")]
        public partial bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayAttribBinding")]
        public partial void VertexArrayAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public partial void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public partial void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public partial void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor")]
        public partial void VertexArrayBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexArrayElementBuffer")]
        public partial void VertexArrayElementBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer")]
        public partial void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public unsafe partial void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] IntPtr* offsets, [Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public partial void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<uint> buffers, [Flow(FlowDirection.In)] Span<IntPtr> offsets, [Flow(FlowDirection.In)] Span<uint> strides);

        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public partial void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public partial GLEnum CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public unsafe partial void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public partial void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public unsafe partial void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public partial void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public unsafe partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public unsafe partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public unsafe partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public partial void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClipControl")]
        public partial void ClipControl([Flow(FlowDirection.In)] ClipControlOrigin origin, [Flow(FlowDirection.In)] ClipControlDepth depth);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public unsafe partial void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public partial void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public unsafe partial void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public partial void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public unsafe partial void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public partial void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCreateQueries")]
        public unsafe partial void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glCreateQueries")]
        public partial void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public unsafe partial void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glCreateTextures")]
        public partial void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public unsafe partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public partial void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPNameARB pname, [Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public unsafe partial void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public unsafe partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public partial void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public unsafe partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public unsafe partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public partial void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public unsafe partial void GetnColorTable([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetnColorTable")]
        public partial void GetnColorTable<T0>([Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public unsafe partial void GetnCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnCompressedTexImage")]
        public partial void GetnCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int lod, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public unsafe partial void GetnConvolutionFilter([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* image);

        [NativeApi(EntryPoint = "glGetnConvolutionFilter")]
        public partial void GetnConvolutionFilter<T0>([Flow(FlowDirection.In)] ConvolutionTarget target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> image) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public unsafe partial void GetnHistogram([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnHistogram")]
        public partial void GetnHistogram<T0>([Flow(FlowDirection.In)] HistogramTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] double* v);

        [NativeApi(EntryPoint = "glGetnMapdv")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<double> v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetnMapfv")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public unsafe partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] int* v);

        [NativeApi(EntryPoint = "glGetnMapiv")]
        public partial void GetnMap([Flow(FlowDirection.In)] MapTarget target, [Flow(FlowDirection.In)] MapQuery query, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<int> v);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public unsafe partial void GetnMinmax([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* values);

        [NativeApi(EntryPoint = "glGetnMinmax")]
        public partial void GetnMinmax<T0>([Flow(FlowDirection.In)] MinmaxTargetEXT target, [Flow(FlowDirection.In)] bool reset, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> values) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetnPixelMapfv")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* values);

        [NativeApi(EntryPoint = "glGetnPixelMapuiv")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public unsafe partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] ushort* values);

        [NativeApi(EntryPoint = "glGetnPixelMapusv")]
        public partial void GetnPixelMap([Flow(FlowDirection.In)] PixelMap map, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<ushort> values);

        [NativeApi(EntryPoint = "glGetnPolygonStipple")]
        public partial void GetnPolygonStipple([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] string pattern);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public unsafe partial void GetnSeparableFilter([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] void* row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] void* column, [Flow(FlowDirection.Out)] void* span);

        [NativeApi(EntryPoint = "glGetnSeparableFilter")]
        public partial void GetnSeparableFilter<T0, T1, T2>([Flow(FlowDirection.In)] SeparableTargetEXT target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint rowBufSize, [Flow(FlowDirection.Out)] Span<T0> row, [Flow(FlowDirection.In)] uint columnBufSize, [Flow(FlowDirection.Out)] Span<T1> column, [Flow(FlowDirection.Out)] Span<T2> span) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged;

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public unsafe partial void GetnTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetnTexImage")]
        public partial void GetnTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public partial void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public unsafe partial void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureImage")]
        public partial void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public unsafe partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public partial void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public unsafe partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public partial void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public unsafe partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public partial void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public unsafe partial void GetTextureSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTextureSubImage")]
        public partial void GetTextureSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public unsafe partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public unsafe partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public partial void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public unsafe partial void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public partial void GetTransformFeedbacki64([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public unsafe partial void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public partial void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public unsafe partial void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public partial void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public unsafe partial void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] long* param);

        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public partial void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<long> param);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public unsafe partial void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public partial void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public unsafe partial void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public partial void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public unsafe partial void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public unsafe partial void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage);

        [NativeApi(EntryPoint = "glNamedBufferData")]
        public partial void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public partial void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer buf);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public unsafe partial void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ColorBuffer* bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public partial void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ColorBuffer> bufs);

        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public partial void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public partial void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer src);

        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public partial void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public partial void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public partial void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public partial void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public partial void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureBuffer")]
        public partial void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public partial void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTextureParameterf")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<float> param);

        [NativeApi(EntryPoint = "glTextureParameteri")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public unsafe partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public partial void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> param);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public unsafe partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public partial void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<uint> @params);

        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public partial void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public partial void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public partial void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public partial void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public partial void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public unsafe partial void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public partial void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public unsafe partial void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public partial void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public unsafe partial void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public partial void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public partial void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public partial void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public partial void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public unsafe partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindImageTextures")]
        public partial void BindImageTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public unsafe partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glBindSamplers")]
        public partial void BindSamplers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glBindTextures")]
        public unsafe partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glBindTextures")]
        public partial void BindTextures([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> textures);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public unsafe partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* strides);

        [NativeApi(EntryPoint = "glBindVertexBuffers")]
        public partial void BindVertexBuffers([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> strides);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public partial void BufferStorage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImage")]
        public unsafe partial void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage")]
        public partial void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public unsafe partial void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public partial void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public unsafe partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glBindBuffersBase")]
        public partial void BindBuffersBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public unsafe partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] IntPtr* offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] UIntPtr* sizes);

        [NativeApi(EntryPoint = "glBindBuffersRange")]
        public partial void BindBuffersRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> buffers, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<IntPtr> offsets, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<UIntPtr> sizes);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public unsafe partial void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glBufferStorage")]
        public partial void BufferStorage<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexImage")]
        public unsafe partial void ClearTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexImage")]
        public partial void ClearTexImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public unsafe partial void ClearTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearTexSubImage")]
        public partial void ClearTexSubImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindVertexBuffer")]
        public partial void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public unsafe partial void ClearBufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public partial void ClearBufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public unsafe partial void ClearBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public partial void ClearBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] GLEnum srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] GLEnum dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public unsafe partial void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public partial void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] Span<T0> userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ref byte buf);

        [NativeApi(EntryPoint = "glDispatchCompute")]
        public partial void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        public partial void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<GLEnum> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<GLEnum> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public unsafe partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public unsafe partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glInvalidateBufferData")]
        public partial void InvalidateBufferData([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glInvalidateBufferSubData")]
        public partial void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public unsafe partial void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public partial void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public unsafe partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<GLEnum> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateTexImage")]
        public partial void InvalidateTexImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glInvalidateTexSubImage")]
        public partial void InvalidateTexSubImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public unsafe partial void MultiDrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public partial void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectLabel")]
        public unsafe partial void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref byte label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPopDebugGroup")]
        public partial void PopDebugGroup();

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public unsafe partial void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] byte* message);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] ref byte message);

        [NativeApi(EntryPoint = "glShaderStorageBlockBinding")]
        public partial void ShaderStorageBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint storageBlockIndex, [Flow(FlowDirection.In)] uint storageBlockBinding);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureView")]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glVertexAttribBinding")]
        public partial void VertexAttribBinding([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public partial void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexBindingDivisor")]
        public partial void VertexBindingDivisor([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public unsafe partial void ClearBufferData([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferData")]
        public partial void ClearBufferData<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public unsafe partial void ClearBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glClearBufferSubData")]
        public partial void ClearBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] Span<ProgramResourceProperty> props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndex")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public unsafe partial void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public partial void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public unsafe partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public unsafe partial void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public partial void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectLabel")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTextureView")]
        public partial void TextureView([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint origtexture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint minlevel, [Flow(FlowDirection.In)] uint numlevels, [Flow(FlowDirection.In)] uint minlayer, [Flow(FlowDirection.In)] uint numlayers);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribLFormat")]
        public partial void VertexAttribLFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] GLEnum access, [Flow(FlowDirection.In)] GLEnum format);

        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public partial void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public unsafe partial void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public partial void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public unsafe partial void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public partial void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public partial void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public unsafe partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glMemoryBarrier")]
        public partial void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glTexStorage1D")]
        public partial void TexStorage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public partial void TexStorage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public partial void TexStorage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public partial void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public unsafe partial void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public partial void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public unsafe partial void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public partial void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedbackInstanced")]
        public partial void DrawTransformFeedbackInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public partial void DrawTransformFeedbackStreamInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public unsafe partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glTexStorage1D")]
        public partial void TexStorage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public partial void TexStorage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public partial void TexStorage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glActiveShaderProgram")]
        public partial void ActiveShaderProgram([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glBindProgramPipeline")]
        public partial void BindProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glClearDepthf")]
        public partial void ClearDepth([Flow(FlowDirection.In)] float d);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public unsafe partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> pipelines);

        [NativeApi(EntryPoint = "glDepthRangef")]
        public partial void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDepthRangeArrayv")]
        public unsafe partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glDepthRangeArrayv")]
        public partial void DepthRangeArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref double v);

        [NativeApi(EntryPoint = "glDepthRangeIndexed")]
        public partial void DepthRangeIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double n, [Flow(FlowDirection.In)] double f);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public unsafe partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        [NativeApi(EntryPoint = "glGetDoublei_v")]
        public unsafe partial void GetDouble([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublei_v")]
        public partial void GetDouble([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetFloati_v")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloati_v")]
        public partial void GetFloat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<T0> binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public unsafe partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glIsProgramPipeline")]
        public partial bool IsProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glProgramBinary")]
        public unsafe partial void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glProgramBinary")]
        public partial void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramParameteri")]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramUniform1i")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform1f")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform1d")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0);

        [NativeApi(EntryPoint = "glProgramUniform1dv")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform1dv")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform1ui")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniform2i")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform2f")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform2d")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1);

        [NativeApi(EntryPoint = "glProgramUniform2dv")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform2dv")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform2ui")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniform3i")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform3f")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform3d")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2);

        [NativeApi(EntryPoint = "glProgramUniform3dv")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform3dv")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform3ui")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniform4i")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glProgramUniform4f")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniform4d")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double v0, [Flow(FlowDirection.In)] double v1, [Flow(FlowDirection.In)] double v2, [Flow(FlowDirection.In)] double v3);

        [NativeApi(EntryPoint = "glProgramUniform4dv")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniform4dv")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniform4ui")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv")]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2dv")]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv")]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3dv")]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv")]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4dv")]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv")]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3dv")]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv")]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2dv")]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv")]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4dv")]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv")]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4dv")]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv")]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2dv")]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv")]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3dv")]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        public partial void ReleaseShaderCompiler();

        [NativeApi(EntryPoint = "glScissorArrayv")]
        public unsafe partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorArrayv")]
        public partial void ScissorArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v);

        [NativeApi(EntryPoint = "glScissorIndexed")]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int left, [Flow(FlowDirection.In)] int bottom, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorIndexedv")]
        public unsafe partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorIndexedv")]
        public partial void ScissorIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> shaders, [Flow(FlowDirection.In)] GLEnum binaryformat, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUseProgramStages")]
        public partial void UseProgramStages([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint stages, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgramPipeline")]
        public partial void ValidateProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glVertexAttribL1d")]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public unsafe partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL1dv")]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [NativeApi(EntryPoint = "glVertexAttribL2d")]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public unsafe partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL2dv")]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttribL3d")]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public unsafe partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL3dv")]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttribL4d")]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public unsafe partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL4dv")]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public unsafe partial void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public partial void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glViewportArrayv")]
        public unsafe partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportArrayv")]
        public partial void ViewportArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref float v);

        [NativeApi(EntryPoint = "glViewportIndexedf")]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float w, [Flow(FlowDirection.In)] float h);

        [NativeApi(EntryPoint = "glViewportIndexedfv")]
        public unsafe partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glViewportIndexedfv")]
        public partial void ViewportIndexed([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public unsafe partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] Span<int> range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdv")]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glProgramParameteri")]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public unsafe partial void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointer")]
        public partial void VertexAttribLPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public partial void BeginQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBlendEquationi")]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum src, [Flow(FlowDirection.In)] GLEnum dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public unsafe partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public unsafe partial void DrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public partial void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public partial void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public partial void DrawTransformFeedbackStream([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public partial void EndQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public unsafe partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public unsafe partial void GetQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public partial void GetQueryIndexed([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public unsafe partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public unsafe partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetUniformdv")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetUniformdv")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public unsafe partial void GetUniformSubroutine([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public partial void GetUniformSubroutine([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsTransformFeedback")]
        public partial bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glMinSampleShading")]
        public partial void MinSampleShading([Flow(FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glPatchParameteri")]
        public partial void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public unsafe partial void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public partial void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        [NativeApi(EntryPoint = "glPauseTransformFeedback")]
        public partial void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glResumeTransformFeedback")]
        public partial void ResumeTransformFeedback();

        [NativeApi(EntryPoint = "glUniform1d")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glUniform1dv")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform1dv")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniform2d")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glUniform2dv")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform2dv")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniform3d")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glUniform3dv")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform3dv")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniform4d")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glUniform4dv")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniform4dv")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public unsafe partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2dv")]
        public partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public unsafe partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3dv")]
        public partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public unsafe partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4dv")]
        public partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public unsafe partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3dv")]
        public partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public unsafe partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2dv")]
        public partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public unsafe partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4dv")]
        public partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public unsafe partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4dv")]
        public partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public unsafe partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2dv")]
        public partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public unsafe partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] double* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3dv")]
        public partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<double> value);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public unsafe partial void UniformSubroutines([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public partial void UniformSubroutines([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        [NativeApi(EntryPoint = "glBeginQueryIndexed")]
        public partial void BeginQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBlendEquationi")]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public unsafe partial void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public partial void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public partial void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawTransformFeedback")]
        public partial void DrawTransformFeedback([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glDrawTransformFeedbackStream")]
        public partial void DrawTransformFeedbackStream([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint stream);

        [NativeApi(EntryPoint = "glEndQueryIndexed")]
        public partial void EndQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public unsafe partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineName")]
        public partial void GetActiveSubroutineName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public unsafe partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformiv")]
        public partial void GetActiveSubroutineUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] SubroutineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public unsafe partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveSubroutineUniformName")]
        public partial void GetActiveSubroutineUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public unsafe partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetProgramStageiv")]
        public partial void GetProgramStage([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] ProgramStagePName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public unsafe partial void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryIndexediv")]
        public partial void GetQueryIndexed([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSubroutineIndex")]
        public partial uint GetSubroutineIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetSubroutineUniformLocation")]
        public partial int GetSubroutineUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public unsafe partial void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformSubroutineuiv")]
        public partial void GetUniformSubroutine([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] int location, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glPatchParameteri")]
        public partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public unsafe partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float values);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public unsafe partial void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glUniformSubroutinesuiv")]
        public partial void UniformSubroutines([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> indices);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public unsafe partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glBindSampler")]
        public partial void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glColorP3ui")]
        public partial void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public unsafe partial void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public partial void ColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glColorP4ui")]
        public partial void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public unsafe partial void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public partial void ColorP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public unsafe partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public unsafe partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> samplers);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public unsafe partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsSampler")]
        public partial bool IsSampler([Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public unsafe partial void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public unsafe partial void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public unsafe partial void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public unsafe partial void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] GLEnum texture, [Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui")]
        public partial void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public unsafe partial void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public partial void NormalP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glQueryCounter")]
        public partial void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public unsafe partial void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public unsafe partial void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public unsafe partial void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public unsafe partial void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public unsafe partial void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glVertexAttribDivisor")]
        public partial void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public unsafe partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public unsafe partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public unsafe partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public unsafe partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP2ui")]
        public partial void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public unsafe partial void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public partial void VertexP2([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP3ui")]
        public partial void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public unsafe partial void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public partial void VertexP3([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP4ui")]
        public partial void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public unsafe partial void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public partial void VertexP4([Flow(FlowDirection.In)] GLEnum type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glColorP3ui")]
        public partial void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public unsafe partial void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP3uiv")]
        public partial void ColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glColorP4ui")]
        public partial void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public unsafe partial void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glColorP4uiv")]
        public partial void ColorP4([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetQueryObjecti64v")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectui64v")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glMultiTexCoordP1ui")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public unsafe partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP1uiv")]
        public partial void MultiTexCoordP1([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2ui")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public unsafe partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP2uiv")]
        public partial void MultiTexCoordP2([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3ui")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public unsafe partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP3uiv")]
        public partial void MultiTexCoordP3([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4ui")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public unsafe partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glMultiTexCoordP4uiv")]
        public partial void MultiTexCoordP4([Flow(FlowDirection.In)] TextureUnit texture, [Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glNormalP3ui")]
        public partial void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public unsafe partial void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glNormalP3uiv")]
        public partial void NormalP3([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glQueryCounter")]
        public partial void QueryCounter([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryCounterTarget target);

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint param);

        [NativeApi(EntryPoint = "glSecondaryColorP3ui")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public unsafe partial void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* color);

        [NativeApi(EntryPoint = "glSecondaryColorP3uiv")]
        public partial void SecondaryColorP3([Flow(FlowDirection.In)] ColorPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint color);

        [NativeApi(EntryPoint = "glTexCoordP1ui")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public unsafe partial void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP1uiv")]
        public partial void TexCoordP1([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2ui")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public unsafe partial void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP2uiv")]
        public partial void TexCoordP2([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3ui")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public unsafe partial void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP3uiv")]
        public partial void TexCoordP3([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4ui")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public unsafe partial void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* coords);

        [NativeApi(EntryPoint = "glTexCoordP4uiv")]
        public partial void TexCoordP4([Flow(FlowDirection.In)] TexCoordPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint coords);

        [NativeApi(EntryPoint = "glVertexAttribP1ui")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public unsafe partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP1uiv")]
        public partial void VertexAttribP1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2ui")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public unsafe partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP2uiv")]
        public partial void VertexAttribP2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3ui")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public unsafe partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP3uiv")]
        public partial void VertexAttribP3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4ui")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public unsafe partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexAttribP4uiv")]
        public partial void VertexAttribP4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP2ui")]
        public partial void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public unsafe partial void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP2uiv")]
        public partial void VertexP2([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP3ui")]
        public partial void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public unsafe partial void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP3uiv")]
        public partial void VertexP3([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glVertexP4ui")]
        public partial void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public unsafe partial void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glVertexP4uiv")]
        public partial void VertexP4([Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 1), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glClientWaitSync")]
        public partial GLEnum ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDeleteSync")]
        public partial void DeleteSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFenceSync")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] GLEnum condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public unsafe partial void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public partial void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values);

        [NativeApi(EntryPoint = "glIsSync")]
        public partial bool IsSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProvokingVertex")]
        public partial void ProvokingVertex([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glSampleMaski")]
        public partial void SampleMask([Flow(FlowDirection.In)] uint maskNumber, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public partial void TexImage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public partial void TexImage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glWaitSync")]
        public partial void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFenceSync")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public unsafe partial void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public partial void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProvokingVertex")]
        public partial void ProvokingVertex([Flow(FlowDirection.In)] VertexProvokingMode mode);

        [NativeApi(EntryPoint = "glTexImage2DMultisample")]
        public partial void TexImage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexImage3DMultisample")]
        public partial void TexImage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glBindBufferBase")]
        public partial void BindBufferBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange")]
        public partial void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public unsafe partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public unsafe partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public unsafe partial void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public partial void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public partial void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public unsafe partial uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public partial uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] ref byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public unsafe partial void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public unsafe partial void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] ref byte* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices);

        [NativeApi(EntryPoint = "glPrimitiveRestartIndex")]
        public partial void PrimitiveRestartIndex([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public partial void TexBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glUniformBlockBinding")]
        public partial void UniformBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint uniformBlockBinding);

        [NativeApi(EntryPoint = "glBindBufferBase")]
        public partial void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange")]
        public partial void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public unsafe partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public unsafe partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public unsafe partial void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformName")]
        public partial void GetActiveUniformName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string uniformName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] Span<uint> uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public partial uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string uniformBlockName);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBeginConditionalRender")]
        public partial void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] GLEnum primitiveMode);

        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public unsafe partial void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public partial void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public partial void BindFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public partial void BindRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBindVertexArray")]
        public partial void BindVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public partial void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public partial GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glClampColor")]
        public partial void ClampColor([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum clamp);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value);

        [NativeApi(EntryPoint = "glClearBufferfi")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glColorMaski")]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public unsafe partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public unsafe partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public unsafe partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glDisablei")]
        public partial void Disable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnablei")]
        public partial void Enable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEndConditionalRender")]
        public partial void EndConditionalRender();

        [NativeApi(EntryPoint = "glEndTransformFeedback")]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public partial void GenerateMipmap([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public unsafe partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public unsafe partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public unsafe partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public unsafe partial int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public partial int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetStringi")]
        public unsafe partial byte* GetString([Flow(FlowDirection.In)] GLEnum name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsEnabledi")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsFramebuffer")]
        public partial bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsRenderbuffer")]
        public partial bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glIsVertexArray")]
        public partial bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glMapBufferRange")]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** varyings, [Flow(FlowDirection.In)] GLEnum bufferMode);

        [NativeApi(EntryPoint = "glUniform1ui")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glUniform1uiv")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform1uiv")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glUniform2ui")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glUniform2uiv")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform2uiv")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glUniform3ui")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glUniform3uiv")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform3uiv")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glUniform4ui")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glUniform4uiv")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform4uiv")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> value);

        [NativeApi(EntryPoint = "glVertexAttribI1i")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertexAttribI1ui")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x);

        [NativeApi(EntryPoint = "glVertexAttribI1iv")]
        public unsafe partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI1iv")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        [NativeApi(EntryPoint = "glVertexAttribI1uiv")]
        public unsafe partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI1uiv")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref uint v);

        [NativeApi(EntryPoint = "glVertexAttribI2i")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertexAttribI2ui")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y);

        [NativeApi(EntryPoint = "glVertexAttribI2iv")]
        public unsafe partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI2iv")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI2uiv")]
        public unsafe partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI2uiv")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI3i")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertexAttribI3ui")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z);

        [NativeApi(EntryPoint = "glVertexAttribI3iv")]
        public unsafe partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI3iv")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI3uiv")]
        public unsafe partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI3uiv")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI4i")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexAttribI4ui")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI4bv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4bv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttribI4sv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribI4sv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttribI4usv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttribI4usv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public unsafe partial void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public partial void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBeginConditionalRender")]
        public partial void BeginConditionalRender([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ConditionalRenderMode mode);

        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        [NativeApi(EntryPoint = "glBindFragDataLocation")]
        public partial void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public partial void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public partial void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public partial void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public partial GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClampColor")]
        public partial void ClampColor([Flow(FlowDirection.In)] ClampColorTargetARB target, [Flow(FlowDirection.In)] ClampColorModeARB clamp);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref int value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref uint value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] ref float value);

        [NativeApi(EntryPoint = "glClearBufferfi")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glDisablei")]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnablei")]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture1D")]
        public partial void FramebufferTexture1D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture3D")]
        public partial void FramebufferTexture3D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int zoffset);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public partial void GenerateMipmap([Flow(FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public partial void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public partial int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetStringi")]
        public partial string GetString([Flow(FlowDirection.In)] StringName name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsEnabledi")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glMapBufferRange")]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref uint @params);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** varyings, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        [NativeApi(EntryPoint = "glVertexAttribI4ubv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public unsafe partial void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public partial void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public unsafe partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public unsafe partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public unsafe partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public unsafe partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public unsafe partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public unsafe partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glAttachShader")]
        public partial void AttachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public unsafe partial void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public partial void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glCompileShader")]
        public partial void CompileShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glCreateProgram")]
        public partial uint CreateProgram();

        [NativeApi(EntryPoint = "glCreateShader")]
        public partial uint CreateShader([Flow(FlowDirection.In)] GLEnum type);

        [NativeApi(EntryPoint = "glDeleteProgram")]
        public partial void DeleteProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glDeleteShader")]
        public partial void DeleteShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDetachShader")]
        public partial void DetachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDisableVertexAttribArray")]
        public partial void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] GLEnum* bufs);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<GLEnum> bufs);

        [NativeApi(EntryPoint = "glEnableVertexAttribArray")]
        public partial void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public unsafe partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Span<uint> shaders);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public unsafe partial int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public partial int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public unsafe partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public unsafe partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public unsafe partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> infoLog);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> source);

        [NativeApi(EntryPoint = "glGetUniformfv")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetUniformfv")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetUniformiv")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformiv")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public unsafe partial int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public partial int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIsProgram")]
        public partial bool IsProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glIsShader")]
        public partial bool IsShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glLinkProgram")]
        public partial void LinkProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glShaderSource")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glShaderSource")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length);

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public partial void StencilMaskSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glUniform1f")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glUniform1i")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glUniform1fv")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform1fv")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform1iv")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform1iv")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform2f")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glUniform2i")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glUniform2fv")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform2fv")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform2iv")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform2iv")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform3f")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glUniform3i")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glUniform3fv")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform3fv")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform3iv")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform3iv")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniform4f")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glUniform4i")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glUniform4fv")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform4fv")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniform4iv")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform4iv")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> value);

        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public unsafe partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public unsafe partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public unsafe partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glUseProgram")]
        public partial void UseProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgram")]
        public partial void ValidateProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glVertexAttrib1d")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttrib1dv")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib1dv")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref double v);

        [NativeApi(EntryPoint = "glVertexAttrib1f")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref float v);

        [NativeApi(EntryPoint = "glVertexAttrib1s")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x);

        [NativeApi(EntryPoint = "glVertexAttrib1sv")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib1sv")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref short v);

        [NativeApi(EntryPoint = "glVertexAttrib2d")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttrib2dv")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib2dv")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib2f")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib2s")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        [NativeApi(EntryPoint = "glVertexAttrib2sv")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib2sv")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib3d")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttrib3dv")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib3dv")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib3f")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib3s")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        [NativeApi(EntryPoint = "glVertexAttrib3sv")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib3sv")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4bv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4bv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4d")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttrib4dv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttrib4dv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glVertexAttrib4f")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glVertexAttrib4iv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4iv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttrib4s")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z, [Flow(FlowDirection.In)] short w);

        [NativeApi(EntryPoint = "glVertexAttrib4sv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4sv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4uiv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4uiv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttrib4usv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4usv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nbv")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nbv")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Niv")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Niv")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nsv")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nsv")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nub")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte x, [Flow(FlowDirection.In)] byte y, [Flow(FlowDirection.In)] byte z, [Flow(FlowDirection.In)] byte w);

        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nuiv")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nuiv")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nusv")]
        public unsafe partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nusv")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public partial void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glCreateShader")]
        public partial uint CreateShader([Flow(FlowDirection.In)] ShaderType type);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<DrawBufferMode> bufs);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public partial int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public unsafe partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public unsafe partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public unsafe partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string source);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public partial int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribdv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<double> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<float> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public partial void StencilMaskSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glVertexAttrib4ubv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttrib4Nubv")]
        public partial void VertexAttrib4N([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBeginQuery")]
        public partial void BeginQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindBuffer")]
        public partial void BindBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferData")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubData")]
        public unsafe partial void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubData")]
        public partial void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public unsafe partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public unsafe partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> ids);

        [NativeApi(EntryPoint = "glEndQuery")]
        public partial void EndQuery([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public unsafe partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        [NativeApi(EntryPoint = "glGenQueries")]
        public unsafe partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenQueries")]
        public partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public unsafe partial void GetBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public partial void GetBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public partial void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsBuffer")]
        public partial bool IsBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glIsQuery")]
        public partial bool IsQuery([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glMapBuffer")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum access);

        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public partial bool UnmapBuffer([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glBeginQuery")]
        public partial void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindBuffer")]
        public partial void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBufferData")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubData")]
        public unsafe partial void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubData")]
        public partial void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glEndQuery")]
        public partial void EndQuery([Flow(FlowDirection.In)] QueryTarget target);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public unsafe partial void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glGetBufferSubData")]
        public partial void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectiv")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glMapBuffer")]
        public unsafe partial void* MapBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferAccessARB access);

        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public partial bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target);

        [NativeApi(EntryPoint = "glBlendColor")]
        public partial void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public partial void BlendEquation([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public partial void MultiDrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public unsafe partial void MultiDrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPointParameterf")]
        public partial void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public partial void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glPointParameteri")]
        public partial void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public partial void PointParameter([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public partial void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawArrays")]
        public partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount);

        [NativeApi(EntryPoint = "glMultiDrawElements")]
        public unsafe partial void MultiDrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint drawcount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPointParameterf")]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glPointParameterfv")]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glPointParameteri")]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public unsafe partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameteriv")]
        public partial void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glActiveTexture")]
        public partial void ActiveTexture([Flow(FlowDirection.In)] GLEnum texture);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public unsafe partial void CompressedTexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public partial void CompressedTexImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public unsafe partial void CompressedTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public partial void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public unsafe partial void CompressedTexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public partial void CompressedTexSubImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public unsafe partial void CompressedTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public partial void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public unsafe partial void GetCompressedTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public partial void GetCompressedTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSampleCoverage")]
        public partial void SampleCoverage([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glActiveTexture")]
        public partial void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public unsafe partial void CompressedTexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage1D")]
        public partial void CompressedTexImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public unsafe partial void CompressedTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public partial void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public unsafe partial void CompressedTexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage1D")]
        public partial void CompressedTexSubImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public unsafe partial void CompressedTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public partial void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public unsafe partial void GetCompressedTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] void* img);

        [NativeApi(EntryPoint = "glGetCompressedTexImage")]
        public partial void GetCompressedTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Count(Computed = "target, level"), Flow(FlowDirection.Out)] out T0 img) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public partial void CopyTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public unsafe partial void DrawRangeElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public partial void DrawRangeElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public partial void CopyTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public unsafe partial void DrawRangeElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public partial void DrawRangeElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindTexture")]
        public partial void BindTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glCopyTexImage1D")]
        public partial void CopyTexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public partial void CopyTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexSubImage1D")]
        public partial void CopyTexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public partial void CopyTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public unsafe partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> textures);

        [NativeApi(EntryPoint = "glDrawArrays")]
        public partial void DrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElements")]
        public unsafe partial void DrawElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public partial void DrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGenTextures")]
        public unsafe partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glGenTextures")]
        public partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        [NativeApi(EntryPoint = "glIsTexture")]
        public partial bool IsTexture([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glPolygonOffset")]
        public partial void PolygonOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units);

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public unsafe partial void TexSubImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public partial void TexSubImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBindTexture")]
        public partial void BindTexture([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glCopyTexImage1D")]
        public partial void CopyTexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public partial void CopyTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexSubImage1D")]
        public partial void CopyTexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public partial void CopyTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDrawArrays")]
        public partial void DrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElements")]
        public unsafe partial void DrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public partial void DrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ref T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public unsafe partial void TexSubImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage1D")]
        public partial void TexSubImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBlendFunc")]
        public partial void BlendFunc([Flow(FlowDirection.In)] GLEnum sfactor, [Flow(FlowDirection.In)] GLEnum dfactor);

        [NativeApi(EntryPoint = "glClear")]
        public partial void Clear([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glClearColor")]
        public partial void ClearColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glClearDepth")]
        public partial void ClearDepth([Flow(FlowDirection.In)] double depth);

        [NativeApi(EntryPoint = "glClearStencil")]
        public partial void ClearStencil([Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glColorMask")]
        public partial void ColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glCullFace")]
        public partial void CullFace([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glDepthFunc")]
        public partial void DepthFunc([Flow(FlowDirection.In)] GLEnum func);

        [NativeApi(EntryPoint = "glDepthMask")]
        public partial void DepthMask([Flow(FlowDirection.In)] bool flag);

        [NativeApi(EntryPoint = "glDepthRange")]
        public partial void DepthRange([Flow(FlowDirection.In)] double n, [Flow(FlowDirection.In)] double f);

        [NativeApi(EntryPoint = "glDisable")]
        public partial void Disable([Flow(FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glDrawBuffer")]
        public partial void DrawBuffer([Flow(FlowDirection.In)] GLEnum buf);

        [NativeApi(EntryPoint = "glEnable")]
        public partial void Enable([Flow(FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glFinish")]
        public partial void Finish();

        [NativeApi(EntryPoint = "glFlush")]
        public partial void Flush();

        [NativeApi(EntryPoint = "glFrontFace")]
        public partial void FrontFace([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public unsafe partial void GetDouble([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public partial void GetDouble([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetError")]
        public partial GLEnum GetError();

        [NativeApi(EntryPoint = "glGetFloatv")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public partial void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public partial void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetString")]
        public unsafe partial byte* GetString([Flow(FlowDirection.In)] GLEnum name);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public unsafe partial void GetTexImage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public partial void GetTexImage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glHint")]
        public partial void Hint([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glIsEnabled")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glLineWidth")]
        public partial void LineWidth([Flow(FlowDirection.In)] float width);

        [NativeApi(EntryPoint = "glLogicOp")]
        public partial void LogicOp([Flow(FlowDirection.In)] GLEnum opcode);

        [NativeApi(EntryPoint = "glPixelStoref")]
        public partial void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelStorei")]
        public partial void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointSize")]
        public partial void PointSize([Flow(FlowDirection.In)] float size);

        [NativeApi(EntryPoint = "glPolygonMode")]
        public partial void PolygonMode([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glReadBuffer")]
        public partial void ReadBuffer([Flow(FlowDirection.In)] GLEnum src);

        [NativeApi(EntryPoint = "glReadPixels")]
        public unsafe partial void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public partial void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glScissor")]
        public partial void Scissor([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glStencilFunc")]
        public partial void StencilFunc([Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMask")]
        public partial void StencilMask([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] GLEnum zpass);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public unsafe partial void TexImage1D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public partial void TexImage1D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexParameterf")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glViewport")]
        public partial void Viewport([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glBlendFunc")]
        public partial void BlendFunc([Flow(FlowDirection.In)] BlendingFactor sfactor, [Flow(FlowDirection.In)] BlendingFactor dfactor);

        [NativeApi(EntryPoint = "glCullFace")]
        public partial void CullFace([Flow(FlowDirection.In)] CullFaceMode mode);

        [NativeApi(EntryPoint = "glDepthFunc")]
        public partial void DepthFunc([Flow(FlowDirection.In)] DepthFunction func);

        [NativeApi(EntryPoint = "glDisable")]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap cap);

        [NativeApi(EntryPoint = "glDrawBuffer")]
        public partial void DrawBuffer([Flow(FlowDirection.In)] DrawBufferMode buf);

        [NativeApi(EntryPoint = "glEnable")]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap cap);

        [NativeApi(EntryPoint = "glFrontFace")]
        public partial void FrontFace([Flow(FlowDirection.In)] FrontFaceDirection mode);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public unsafe partial void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* data);

        [NativeApi(EntryPoint = "glGetDoublev")]
        public partial void GetDouble([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public partial void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public partial void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetString")]
        public partial string GetString([Flow(FlowDirection.In)] StringName name);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public unsafe partial void GetTexImage([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glGetTexImage")]
        public partial void GetTexImage<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, level, format, type"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glHint")]
        public partial void Hint([Flow(FlowDirection.In)] HintTarget target, [Flow(FlowDirection.In)] HintMode mode);

        [NativeApi(EntryPoint = "glIsEnabled")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap cap);

        [NativeApi(EntryPoint = "glLogicOp")]
        public partial void LogicOp([Flow(FlowDirection.In)] LogicOp opcode);

        [NativeApi(EntryPoint = "glPixelStoref")]
        public partial void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glPixelStorei")]
        public partial void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPolygonMode")]
        public partial void PolygonMode([Flow(FlowDirection.In)] MaterialFace face, [Flow(FlowDirection.In)] PolygonMode mode);

        [NativeApi(EntryPoint = "glReadBuffer")]
        public partial void ReadBuffer([Flow(FlowDirection.In)] ReadBufferMode src);

        [NativeApi(EntryPoint = "glReadPixels")]
        public unsafe partial void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public partial void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glStencilFunc")]
        public partial void StencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] StencilOp zpass);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public unsafe partial void TexImage1D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage1D")]
        public partial void TexImage1D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] ref T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexParameterf")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawArraysIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawArraysIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawArraysIndirectCount(mode, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void MultiDrawElementsIndirectCount<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] int drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // IntPtrOverloader
            MultiDrawElementsIndirectCount(mode, type, indirect, new IntPtr(drawcount), maxdrawcount, stride);
        }

        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyNamedBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public unsafe uint CreateBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateBuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateFramebuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe uint CreateRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateRenderbuffers(n, &ret);
            return ret;
        }

        public unsafe uint CreateSampler()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSamplers(n, &ret);
            return ret;
        }

        public unsafe uint CreateTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe uint CreateVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe byte GetnPolygonStipple()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            byte ret = default;
            GetnPolygonStipple(bufSize, &ret);
            return ret;
        }

        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length), access);
        }

        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), ref data);
        }

        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TransformFeedbackBufferRange(xfb, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void BufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BufferStorage<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BufferStorage([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BufferStorage<T0>([Flow(FlowDirection.In)] BufferStorageTarget target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferStorage(target, new UIntPtr(size), data, flags);
        }

        public unsafe void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            BindVertexBuffer(bindingindex, buffer, new IntPtr(offset), stride);
        }

        public unsafe void ClearBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        public unsafe void DispatchComputeIndirect([Flow(FlowDirection.In)] int indirect)
        {
            // IntPtrOverloader
            DispatchComputeIndirect(new IntPtr(indirect));
        }

        public unsafe void InvalidateBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            InvalidateBufferSubData(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void ClearBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        public unsafe void ClearBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearBufferSubData(target, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, ref data);
        }

        public unsafe void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TexBufferRange(target, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        public unsafe void DeleteProgramPipeline([Count(Parameter = "n"), Flow(FlowDirection.In)] uint pipelines)
        {
            // ArrayParameterOverloader
            DeleteProgramPipelines(1, &pipelines);
        }

        public unsafe uint GenProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.MarshalStringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            return ret;
        }

        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        public unsafe GLEnum ClientWaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            return ClientWaitSync(new IntPtr(sync), flags, timeout);
        }

        public unsafe void DeleteSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            DeleteSync(new IntPtr(sync));
        }

        public unsafe long GetInteger64([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        public unsafe bool IsSync([Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return IsSync(new IntPtr(sync));
        }

        public unsafe void WaitSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout)
        {
            // IntPtrOverloader
            WaitSync(new IntPtr(sync), flags, timeout);
        }

        public unsafe long GetInteger64([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, length, values);
        }

        public unsafe void GetSync([Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // IntPtrOverloader
            GetSync(new IntPtr(sync), pname, count, out length, values);
        }

        public unsafe void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (byte**) SilkMarshal.MarshalStringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
            SilkMarshal.CopyPtrToStringArray((IntPtr) uniformNames, uniformNamesSa);
        }

        public unsafe void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            BindBufferRange(target, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public unsafe void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyBufferSubData(readTarget, writeTarget, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public unsafe void DeleteFramebuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint framebuffers)
        {
            // ArrayParameterOverloader
            DeleteFramebuffers(1, &framebuffers);
        }

        public unsafe void DeleteRenderbuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint renderbuffers)
        {
            // ArrayParameterOverloader
            DeleteRenderbuffers(1, &renderbuffers);
        }

        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe uint GenFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFramebuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenRenderbuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] GLEnum bufferMode)
        {
            // StringArrayOverloader
            var varyings = (byte**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        public unsafe void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedBufferRange(target, new IntPtr(offset), new UIntPtr(length));
        }

        public unsafe void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapBufferRange(target, new IntPtr(offset), new UIntPtr(length), access);
        }

        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // StringArrayOverloader
            var varyings = (byte**) SilkMarshal.MarshalStringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
        }

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.MarshalStringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
        }

        public unsafe void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
        }

        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage)
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferData(target, new UIntPtr(size), data, usage);
        }

        public unsafe void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            BufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void GetBufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetBufferSubData(target, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        public unsafe uint GenTexture()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTextures(n, &ret);
            return ret;
        }

        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        public unsafe double GetDouble([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            double ret = default;
            GetDouble(pname, &ret);
            return ret;
        }

        public unsafe float GetFloat([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        public unsafe int GetInteger([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        public unsafe double GetDouble([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            double ret = default;
            GetDouble(pname, &ret);
            return ret;
        }

        public unsafe float GetFloat([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        public unsafe int GetInteger([Flow(FlowDirection.In)] GetPName pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }


        public GL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

