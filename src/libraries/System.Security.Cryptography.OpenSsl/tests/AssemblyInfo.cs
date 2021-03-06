// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

[assembly: SkipOnCoreClr("https://github.com/dotnet/runtime/issues/2176", TestPlatforms.OSX)]
[assembly: SkipOnMono("https://github.com/dotnet/runtime/issues/2176", TestPlatforms.OSX)]