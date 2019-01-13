//=============================================================================
// System  : Web Control With Resource Server Handler
// File    : AssemblyInfo.cs
// Author  : Eric Woodruff
// Updated : 04/02/2006
// Compiler: Microsoft Visual C#
//
// A demo web control used to show how the resource server handler works.
//
// This code may be used in compiled form in any way you desire.  This
// file may be redistributed by any means in modified or unmodified form
// PROVIDING that this notice and the author's name and any copyright
// notices remain intact.
//
// This file is provided "as is" with no warranty either express or
// implied.  The author accepts no liability for any damage or loss of
// business that this product may cause.
//
// Version     Date     Who  Comments
// ============================================================================
// 1.0.0.0  03/30/2003  EFW  Created the code
// 1.0.1.0  04/07/2003  EFW  Converted from Page to IHttpHandler
// 1.1.0.0  04/02/2006  EFW  Removed ReadBinaryResource as it isn't needed.
//=============================================================================

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Security.Permissions;

//
// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle("Demo Web Control")]
[assembly: AssemblyDescription("A demo web control to show off the resource server handler class")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Eric Woodruff")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]

// No special permissions are required by this assembly
[assembly: SecurityPermission(SecurityAction.RequestMinimum, Execution=true)]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers
// by using the '*' as shown below:

[assembly: AssemblyVersion("1.1.0.0")]

//
// Tag prefix for the custom controls
//
[assembly: TagPrefix("ResServerTest.Web.Controls", "EWRP") ]
