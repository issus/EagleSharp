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
     
    public partial class Variant
    {
        public Variant()
        {
            Populate = VariantPopulate.yes;
        }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("populate")]
        [DefaultValue(VariantPopulate.yes)]
        public VariantPopulate Populate { get; set; }

        /// <remarks/>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <remarks/>
        [XmlAttribute("technology")]
        public string Technology { get; set; }
    }
}