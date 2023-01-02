using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class ModuleInst
    {
        public ModuleInst()
        {
            this.ModuleVariant = "";
            this.Offset = "0";
            this.Smashed = ModuleInstSmashed.no;
            this.Rot = "R0";
        }

        /// <remarks/>
        [XmlElement("attribute")]
        public Attribute[] Attribute { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("module")]
        public string Module { get; set; }

        /// <remarks/>
        [XmlAttribute("modulevariant")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ModuleVariant { get; set; }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("offset")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string Offset { get; set; }

        /// <remarks/>
        [XmlAttribute("smashed")]
        [System.ComponentModel.DefaultValueAttribute(ModuleInstSmashed.no)]
        public ModuleInstSmashed Smashed { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [System.ComponentModel.DefaultValueAttribute("R0")]
        public string Rot { get; set; }
    }
}