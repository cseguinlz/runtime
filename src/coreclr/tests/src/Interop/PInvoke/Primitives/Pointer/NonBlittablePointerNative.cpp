// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#include <xplatform.h>

extern "C" DLL_EXPORT void STDMETHODCALLTYPE Negate(bool* ptr)
{
    *ptr = !*ptr;
}
