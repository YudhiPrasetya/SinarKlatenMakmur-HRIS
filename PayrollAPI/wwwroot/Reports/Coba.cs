///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 20.7.4                                    //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = False
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = PayrollAPI.wwwroot.Reports
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// MixedContentHandling                     = TreatAsAny
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    D:\SKM\SinarKlatenMakmur\PayrollAPI\wwwroot\Reports\Coba.xsd


namespace PayrollAPI.wwwroot.Reports
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("20.7.4.12782", "Free Community Edition", "M9WDQLWDQNEEVNLX", LiquidTechnologies.XmlObjects.LicenseTermsType.CommunityEdition)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

}

namespace PayrollAPI.wwwroot.Reports.Xs
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace PayrollAPI.wwwroot.Reports.Mstns
{
    #region Elements
    /// <summary>A class representing the root XSD element Coba@http://tempuri.org/Coba.xsd</summary>
    /// <XsdPath>schema:Coba.xsd/element:Coba</XsdPath>
    /// <XsdFile>D:\SKM\SinarKlatenMakmur\PayrollAPI\wwwroot\Reports\Coba.xsd</XsdFile>
    /// <XsdLocation>12:3-26:16</XsdLocation>
    [LxSimpleElementDefinition("Coba", "http://tempuri.org/Coba.xsd", ElementScopeType.GlobalElement)]
    public partial class CobaElm
    {
        /// <summary>A collection of <see cref="PayrollAPI.wwwroot.Reports.Mstns.CobaElm.Coba1Elm" /></summary>
        [LxElementRef(0, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<PayrollAPI.wwwroot.Reports.Mstns.CobaElm.Coba1Elm> Cobas { get; } = new List<PayrollAPI.wwwroot.Reports.Mstns.CobaElm.Coba1Elm>();

        /// <summary>Represent the inline xs:element Coba@http://tempuri.org/Coba.xsd.</summary>
        /// <XsdPath>schema:Coba.xsd/element:Coba/choice/element:Coba</XsdPath>
        /// <XsdFile>D:\SKM\SinarKlatenMakmur\PayrollAPI\wwwroot\Reports\Coba.xsd</XsdFile>
        /// <XsdLocation>15:9-23:22</XsdLocation>
        [LxSimpleElementDefinition("Coba", "http://tempuri.org/Coba.xsd", ElementScopeType.InlineElement)]
        public partial class Coba1Elm
        {
            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue(0, "NIK", "http://tempuri.org/Coba.xsd", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1)]
            public System.String NIK { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue(1, "Nama", "http://tempuri.org/Coba.xsd", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1)]
            public System.String Nama { get; set; }

            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
            [LxElementValue(2, "GrupKerja", "http://tempuri.org/Coba.xsd", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1)]
            public System.String GrupKerja { get; set; }

        }

    }

    #endregion

}

namespace PayrollAPI.wwwroot.Reports
{
    /// <summary>
    /// Provides a validator based on the original XSD schema files. 
    /// </summary>
    public partial class CobaValidator : LiquidTechnologies.XmlObjects.XsdValidator
    {
        /// <summary>
        /// Initializes the validator, loads and compiles the XSD schemas.
        /// </summary>
        /// <remarks>
        /// This is an expensive operation so consider caching this object.
        /// </remarks>
        public CobaValidator()
            : base(typeof(CobaValidator).Assembly, "PayrollAPI.CobaResources.SchemaData")
        {
        }
    }
}