// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_ENCRYPTION_GUID_OUTPUT")]
    public unsafe partial struct AuthenticatedQueryAccessibilityEncryptionGuidOutput
    {
        public AuthenticatedQueryAccessibilityEncryptionGuidOutput
        (
            AuthenticatedQueryOutput? output = null,
            uint? encryptionGuidIndex = null,
            Guid? encryptionGuid = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (encryptionGuidIndex is not null)
            {
                EncryptionGuidIndex = encryptionGuidIndex.Value;
            }

            if (encryptionGuid is not null)
            {
                EncryptionGuid = encryptionGuid.Value;
            }
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncryptionGuidIndex")]
        public uint EncryptionGuidIndex;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "EncryptionGuid")]
        public Guid EncryptionGuid;
    }
}
