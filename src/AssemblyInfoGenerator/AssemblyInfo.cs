using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("Autodesk, Inc")]
[assembly: AssemblyProduct("Greg")]
[assembly: AssemblyTitle("Greg")]
[assembly: AssemblyDescription("The Dynamo Package Manager .NET client.")]
[assembly: AssemblyCopyright("Copyright � Autodesk, Inc 2022")]
[assembly: AssemblyTrademark("")]

// Make it easy to distinguish Debug and Release (i.e. Retail) builds;
// for example, through the file properties window.
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: CLSCompliant(false)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// Note that the assembly version does not get incremented for every build
// to avoid problems with assembly binding (or requiring a policy or
// <bindingRedirect> in the config file).
//
// The AssemblyFileVersionAttribute is incremented with every build in order
// to distinguish one build from another. AssemblyFileVersion is specified
// in AssemblyVersionInfo.cs so that it can be easily incremented by the
// automated build process.
[assembly: AssemblyVersion("2.5.0.5065")]


// By default, the "Product version" shown in the file properties window is
// the same as the value specified for AssemblyFileVersionAttribute.
// Set AssemblyInformationalVersionAttribute to be the same as
// AssemblyVersionAttribute so that the "Product version" in the file
// properties window matches the version displayed in the GAC shell extension.
//[assembly: AssemblyInformationalVersion("1.0.0.0")] // a.k.a. "Product version"
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyFileVersion("2.5.0.5065")]
