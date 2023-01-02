using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Board
    {
        /// <remarks/>
        [XmlAttribute("description")]
        public string Description { get; set; }

        /// <remarks/>
        [XmlArrayItem("circle", typeof(Circle), IsNullable = false)]
        public Circle[] Circles { get; set; }

        [XmlArrayItem("dimension", typeof(Dimension), IsNullable = false)]
        public Dimension[] Dimensions { get; set; }

        [XmlArrayItem("frame", typeof(Frame), IsNullable = false)]
        public Frame[] Frames { get; set; }

        [XmlArrayItem("hole", typeof(Hole), IsNullable = false)]
        public Hole[] Holes { get; set; }

        [XmlArrayItem("polygon", typeof(Polygon), IsNullable = false)]
        public Polygon[] Polygons { get; set; }

        [XmlArrayItem("rectangle", typeof(Rectangle), IsNullable = false)]
        public Rectangle[] Rectangles { get; set; }

        [XmlArrayItem("text", typeof(Text), IsNullable = false)]
        public Text[] Text { get; set; }

        [XmlArrayItem("wire", typeof(Wire), IsNullable = false)]
        public Wire[] Wires { get; set; }

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
        [XmlElement("designrules")]
        public DesignRules DesignRules { get; set; }

        /// <remarks/>
        [XmlElement("autorouter")]
        public AutoRouter Autorouter { get; set; }

        /// <remarks/>
        [XmlElement("elements")]
        public Elements Elements { get; set; }

        /// <remarks/>
        [XmlElement("signals")]
        public Signals Signals { get; set; }

        /// <remarks/>
        [XmlElement("errors")]
        public Errors Errors { get; set; }

        /// <remarks/>
        [XmlAttribute("limitedwidth")]
        public string LimitedWidth { get; set; }
    }
}