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
     
    public partial class Plain
    {

        /// <remarks/>
        [XmlElement("circle", typeof(Circle))]
        [XmlElement("dimension", typeof(Dimension))]
        [XmlElement("frame", typeof(Frame))]
        [XmlElement("hole", typeof(Hole))]
        [XmlElement("polygon", typeof(Polygon))]
        [XmlElement("rectangle", typeof(Rectangle))]
        [XmlElement("text", typeof(Text))]
        [XmlElement("wire", typeof(Wire))]
        public object[] Items { get; set; }
    }
}