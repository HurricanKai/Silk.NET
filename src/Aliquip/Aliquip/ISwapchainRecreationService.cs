﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Maths;

namespace Aliquip
{
    public interface ISwapchainRecreationService
    {
        void RecreateSwapchain(Vector2D<int>? newSize);
    }
}