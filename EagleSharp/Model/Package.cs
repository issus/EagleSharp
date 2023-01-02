using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Package
    {

        /// <remarks/>
        [XmlElement("description")]
        public Description Description { get; set; }

        /// <remarks/>
        [XmlElement("circle", typeof(Circle))]
        [XmlElement("dimension", typeof(Dimension))]
        [XmlElement("frame", typeof(Frame))]
        [XmlElement("hole", typeof(Hole))]
        [XmlElement("pad", typeof(Pad))]
        [XmlElement("polygon", typeof(Polygon))]
        [XmlElement("rectangle", typeof(Rectangle))]
        [XmlElement("smd", typeof(SMD))]
        [XmlElement("text", typeof(Text))]
        [XmlElement("wire", typeof(Wire))]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}