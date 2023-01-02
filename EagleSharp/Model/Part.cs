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
     
    public partial class Part
    {
        public Part()
        {
            Technology = "";
        }

        /// <remarks/>
        [XmlElement("attribute")]
        public Attribute[] Attribute { get; set; }

        /// <remarks/>
        [XmlElement("variant")]
        public Variant[] Variant { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("library")]
        public string Library { get; set; }

        /// <remarks/>
        [XmlAttribute("deviceset")]
        public string DeviceSet { get; set; }

        /// <remarks/>
        [XmlAttribute("device")]
        public string Device { get; set; }

        /// <remarks/>
        [XmlAttribute("technology")]
        [DefaultValue("")]
        public string Technology { get; set; }

        /// <remarks/>
        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}