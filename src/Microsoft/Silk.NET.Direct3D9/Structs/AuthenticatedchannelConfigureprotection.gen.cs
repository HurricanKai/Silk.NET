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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_CONFIGUREPROTECTION")]
    public unsafe partial struct AuthenticatedchannelConfigureprotection
    {
        public AuthenticatedchannelConfigureprotection
        (
            AuthenticatedchannelConfigureInput? parameters = null,
            AuthenticatedchannelProtectionFlags? protections = null
        ) : this()
        {
            if (parameters is not null)
            {
                Parameters = parameters.Value;
            }

            if (protections is not null)
            {
                Protections = protections.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedchannelConfigureInput Parameters;

        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS")]
        [NativeName("Name", "Protections")]
        public AuthenticatedchannelProtectionFlags Protections;
    }
}
