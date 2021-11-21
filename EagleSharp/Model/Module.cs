using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Module
    {
        public Module()
        {
            this.Prefix = "";
        }

        /// <remarks/>
        [XmlElement("description")]
        public Description Description { get; set; }

        /// <remarks/>
        [XmlElement("ports")]
        public Ports Ports { get; set; }

        /// <remarks/>
        [XmlElement("variantdefs")]
        public VariantDefs VariantDefs { get; set; }

        /// <remarks/>
        [XmlElement("parts")]
        public Parts Parts { get; set; }

        /// <remarks/>
        [XmlElement("sheets")]
        public Sheets Sheets { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("prefix")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Prefix { get; set; }

        /// <remarks/>
        [XmlAttribute("dx")]
        public string DX { get; set; }

        /// <remarks/>
        [XmlAttribute("dy")]
        public string DY { get; set; }
    }
}