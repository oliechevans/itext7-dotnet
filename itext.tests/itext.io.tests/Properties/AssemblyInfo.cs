﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("iText.IO.Tests")]
[assembly: AssemblyDescription ("")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany ("iText Group NV")]
[assembly: AssemblyProduct ("iText")]
[assembly: AssemblyCopyright ("Copyright (c) 1998-2016 iText Group NV")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("a53a5dd3-787b-4563-8778-1d76bdad57ba")]

[assembly: AssemblyVersion("7.0.1.1")]
[assembly: AssemblyFileVersion("7.0.1.1")]

#if !NETSTANDARD1_6
[assembly: NUnit.Framework.Timeout(300000)]
#endif
