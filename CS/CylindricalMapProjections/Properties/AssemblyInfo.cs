// Developer Express Code Central Example:
// How to provide cylindrical equal-area projections of a map
// 
// This example illustrates how to get map equal-area projections (Lambert,
// Behrmann, Tristan Edwards, Peters, Gall orthographic and Balthasart) for the
// shapes loaded from the Shapefiles (Countries.shp, Countries.dbf).
// 
// To
// accomplish this task, create an EqualAreaProjection
// (http://help.devexpress.com/#Silverlight/clsDevExpressXpfMapEqualAreaProjectiontopic)
// object and assign it to the VectorLayerBase.MapProjection
// (http://help.devexpress.com/#Silverlight/DevExpressXpfMapVectorLayerBase_MapProjectiontopic)
// property. Then, specify the Width/height aspect ratio for each equal area
// projection using the VectorLayerBase.InitialMapSize
// (http://help.devexpress.com/#Silverlight/DevExpressXpfMapVectorLayerBase_InitialMapSizetopic)
// property. To learn more about the equal-area projections, see Cylindrical
// equal-area projection
// (http://en.wikipedia.org/wiki/Cylindrical_equal-area_projection).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4397

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("CylindricalMapProjections")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("CylindricalMapProjections")]
[assembly: AssemblyCopyright("Copyright ©  2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("184be1ea-0939-424e-9dd1-5d9684e5bc93")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
