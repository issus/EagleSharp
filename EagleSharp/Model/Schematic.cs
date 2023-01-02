using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Schematic
    {
        /// <remarks/>
        [XmlElement("description")]
        public Description Description { get; set; }

        /// <remarks/>
        [XmlElement("libraries")]
        public Libraries Libraries { get; set; }

        /// <remarks/>
        [XmlElement("attributes")]
        public Attributes Attributes { get; set; }

        /// <remarks/>
        [XmlElement("variantdefs")]
        public VariantDefs VariantDefs { get; set; }

        /// <remarks/>
        [XmlElement("classes")]
        public Classes Classes { get; set; }

        /// <remarks/>
        [XmlElement("modules")]
        public Modules Modules { get; set; }

        /// <remarks/>
        [XmlElement("parts")]
        public Parts Parts { get; set; }

        /// <remarks/>
        [XmlElement("sheets")]
        public Sheets Sheets { get; set; }

        /// <remarks/>
        [XmlElement("errors")]
        public Errors Errors { get; set; }

        /// <remarks/>
        [XmlAttribute("xreflabel")]
        public string XRefLabel { get; set; }

        /// <remarks/>
        [XmlAttribute("xrefpart")]
        public string XRefPart { get; set; }
    }
}