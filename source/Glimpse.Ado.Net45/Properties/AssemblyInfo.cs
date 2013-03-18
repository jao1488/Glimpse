﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Glimpse.Core.Extensibility;

[assembly: ComVisible(false)]
[assembly: Guid("396138aa-b068-4a92-ae95-8a21cfb6d2dd")]

[assembly: AssemblyTitle("Glimpse for ADO Assembly")]
[assembly: AssemblyDescription("Main extensibility implementations for running Glimpse with ADO.")]
[assembly: AssemblyProduct("Glimpse.AspNet")]
[assembly: AssemblyCopyright("© 2012 Nik Molnar & Anthony van der Hoorn")]
[assembly: AssemblyTrademark("Glimpse™")]

// Version is in major.minor.build format to support http://semver.org/
// Keep these three attributes in sync
[assembly: AssemblyVersion("1.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")] // Used to specify the NuGet version number at build time

[assembly: InternalsVisibleTo("Glimpse.Test.Ado")]
[assembly: NuGetPackage]