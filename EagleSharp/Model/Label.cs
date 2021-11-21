using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Label
    {
        public Label()
        {
            this.Font = LabelFont.proportional;
            this.Ratio = "8";
            this.Rot = "R0";
            this.XRef = LabelXRef.no;
        }

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
        [System.ComponentModel.DefaultValueAttribute(LabelFont.proportional)]
        public LabelFont Font { get; set; }

        /// <remarks/>
        [XmlAttribute("ratio")]
        [System.ComponentModel.DefaultValueAttribute("8")]
        public string Ratio { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [System.ComponentModel.DefaultValueAttribute("R0")]
        public string Rot { get; set; }

        /// <remarks/>
        [XmlAttribute("xref")]
        [System.ComponentModel.DefaultValueAttribute(LabelXRef.no)]
        public LabelXRef XRef { get; set; }
    }
}