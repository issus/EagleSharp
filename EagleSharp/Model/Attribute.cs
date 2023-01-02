using System.ComponentModel;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Attribute
    {

        public Attribute()
        {
            this.Rot = "R0";
            this.Display = AttributeDisplay.value;
            this.Constant = AttributeConstant.no;
        }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("size")]
        public string Size { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("font")]
        public AttributeFont Font { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool FontSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("ratio")]
        public string Ratio { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [DefaultValue("R0")]
        public string Rot { get; set; }

        /// <remarks/>
        [XmlAttribute("display")]
        [DefaultValue(AttributeDisplay.value)]
        public AttributeDisplay Display { get; set; }

        /// <remarks/>
        [XmlAttribute("constant")]
        [DefaultValue(AttributeConstant.no)]
        public AttributeConstant Constant { get; set; }
    }
}