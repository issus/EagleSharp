using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Dimension
    {
        public Dimension()
        {
            this.DType = DimensionDType.parallel;
            this.ExtWidth = "0";
            this.ExtLength = "0";
            this.ExtOffset = "0";
            this.TextRatio = "8";
            this.Unit = DimensionUnit.mm;
            this.Precision = "2";
            this.Visible = DimensionVisible.no;
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
        [XmlAttribute("y")]
        public string Y2 { get; set; }

        /// <remarks/>
        [XmlAttribute("x3")]
        public string X3 { get; set; }

        /// <remarks/>
        [XmlAttribute("y3")]
        public string Y3 { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("dtype")]
        [System.ComponentModel.DefaultValueAttribute(DimensionDType.parallel)]
        public DimensionDType DType { get; set; }

        /// <remarks/>
        [XmlAttribute("width")]
        public string Width { get; set; }

        /// <remarks/>
        [XmlAttribute("extwidth")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string ExtWidth { get; set; }

        /// <remarks/>
        [XmlAttribute("extlength")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string ExtLength { get; set; }

        /// <remarks/>
        [XmlAttribute("extoffset")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string ExtOffset { get; set; }

        /// <remarks/>
        [XmlAttribute("textsize")]
        public string TextSize { get; set; }

        /// <remarks/>
        [XmlAttribute("textratio")]
        [System.ComponentModel.DefaultValueAttribute("8")]
        public string TextRatio { get; set; }

        /// <remarks/>
        [XmlAttribute("unit")]
        [System.ComponentModel.DefaultValueAttribute(DimensionUnit.mm)]
        public DimensionUnit Unit { get; set; }

        /// <remarks/>
        [XmlAttribute("precision")]
        [System.ComponentModel.DefaultValueAttribute("2")]
        public string Precision { get; set; }

        /// <remarks/>
        [XmlAttribute("visible")]
        [System.ComponentModel.DefaultValueAttribute(DimensionVisible.no)]
        public DimensionVisible Visible { get; set; }
    }
}