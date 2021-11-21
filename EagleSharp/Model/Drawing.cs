using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Drawing
    {
        /// <remarks/>
        [XmlElement("settings")]
        public Settings Settings { get; set; }

        /// <remarks/>
        [XmlElement("grid")]
        public Grid Grid { get; set; }

        /// <remarks/>
        [XmlElement("layers")]
        public Layers Layers { get; set; }

        /// <remarks/>
        [XmlElement("board", typeof(Board))]
        public Board Board { get; set; }

        [XmlElement("library", typeof(Library))]
        public Library Library { get; set; }

        [XmlElement("schematic", typeof(Schematic))]
        public Schematic Schematic { get; set; }
    }
}