using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EagleSharp.Model
{

    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Sheet
    {

        /// <remarks/>
        [XmlElement("description")]
        public Description Description { get; set; }

        /// <remarks/>
        [XmlArrayItem("circle", typeof(Circle), IsNullable = false)]
        [XmlArrayItem("dimension", typeof(Dimension), IsNullable = false)]
        [XmlArrayItem("frame", typeof(Frame), IsNullable = false)]
        [XmlArrayItem("hole", typeof(Hole), IsNullable = false)]
        [XmlArrayItem("polygon", typeof(Polygon), IsNullable = false)]
        [XmlArrayItem("rectangle", typeof(Rectangle), IsNullable = false)]
        [XmlArrayItem("text", typeof(Text), IsNullable = false)]
        [XmlArrayItem("wire", typeof(Wire), IsNullable = false)]
        public object[] Plain { get; set; }

        /// <remarks/>
        [XmlElement("moduleinsts")]
        public ModuleInsts ModuleInsts { get; set; }

        /// <remarks/>
        [XmlElement("instances")]
        public Instances Instances { get; set; }

        /// <remarks/>
        [XmlElement("busses")]
        public Busses Busses { get; set; }

        /// <remarks/>
        [XmlElement("nets")]
        public Nets Nets { get; set; }
    }
}