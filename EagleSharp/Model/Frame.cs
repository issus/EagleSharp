using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Frame
    {
        public Frame()
        {
            this.BorderLeft = FrameBorderLeft.yes;
            this.BorderTop = FrameBorderTop.yes;
            this.BorderRight = FrameBorderRight.yes;
            this.BorderBottom = FrameBorderBottom.yes;
        }

        /// <remarks/>
        [XmlAttribute("x1")]
        public string X1 { get; set; }

        /// <remarks/>
        [XmlAttribute("y1")]
        public string Y1 { get; set; }

        /// <remarks/>
        [XmlAttribute("x2")]
        public string X2 { get; set; }

        /// <remarks/>
        [XmlAttribute("y2")]
        public string Y2 { get; set; }

        /// <remarks/>
        [XmlAttribute("columns")]
        public string Columns { get; set; }

        /// <remarks/>
        [XmlAttribute("rows")]
        public string Rows { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("border-left")]
        [System.ComponentModel.DefaultValueAttribute(FrameBorderLeft.yes)]
        public FrameBorderLeft BorderLeft { get; set; }

        /// <remarks/>
        [XmlAttribute("border-top")]
        [System.ComponentModel.DefaultValueAttribute(FrameBorderTop.yes)]
        public FrameBorderTop BorderTop { get; set; }

        /// <remarks/>
        [XmlAttribute("border-right")]
        [System.ComponentModel.DefaultValueAttribute(FrameBorderRight.yes)]
        public FrameBorderRight BorderRight { get; set; }

        /// <remarks/>
        [XmlAttribute("border-bottom")]
        [System.ComponentModel.DefaultValueAttribute(FrameBorderBottom.yes)]
        public FrameBorderBottom BorderBottom { get; set; }
    }
}