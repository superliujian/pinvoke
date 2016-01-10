﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace PInvoke
{
    /// <content>
    /// The <see cref="SeverityCodes"/> nested type.
    /// </content>
    public partial struct HResult
    {
        /// <summary>
        /// HRESULT severity codes defined by winerror.h
        /// </summary>
        public enum SeverityCodes : uint
        {
            Success = 0,
            Fail = 1,
        }
    }
}
