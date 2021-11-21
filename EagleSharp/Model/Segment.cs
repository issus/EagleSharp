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
     
    public partial class Segment
    {
        /// <remarks/>
        [XmlArrayItem("junction", typeof(Junction), IsNullable = false)]
        public Junction[] Junctions { get; set; }

        [XmlArrayItem("label", typeof(Label), IsNullable = false)]
        public Label[] Labels { get; set; }

        [XmlArrayItem("pinref", typeof(PinRef), IsNullable = false)]
        public PinRef[] PinRefs { get; set; }

        [XmlArrayItem("portref", typeof(PortRef), IsNullable = false)]
        public PortRef[] PortRefs { get; set; }

        [XmlArrayItem("wire", typeof(Wire), IsNullable = false)]
        public Wire[] Wires { get; set; }
    }
}