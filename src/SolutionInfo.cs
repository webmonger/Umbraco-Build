﻿using System.Reflection;
using System.Resources;

[assembly: AssemblyCompany("Umbraco")]
[assembly: AssemblyCopyright("Copyright � Umbraco 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: NeutralResourcesLanguage("en-US")]

// versions
// read https://stackoverflow.com/questions/64602/what-are-differences-between-assemblyversion-assemblyfileversion-and-assemblyin

// this is the ONLY ONE the CLR cares about for compatibility
// should change ONLY when "hard" breaking compatibility (manual change)
[assembly: AssemblyVersion("0.1.0")]

// these are FYI and changed automatically
[assembly: AssemblyFileVersion("0.1.0")]
[assembly: AssemblyInformationalVersion("0.1.0-alpha.24")]
