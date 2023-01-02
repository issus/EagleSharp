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
     
    public partial class Port
    {
        public Port()
        {
            Direction = PortDirection.io;
        }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("side")]
        public string Side { get; set; }

        /// <remarks/>
        [XmlAttribute("coord")]
        public string Coord { get; set; }

        /// <remarks/>
        [XmlAttribute("direction")]
        [DefaultValue(PortDirection.io)]
        public PortDirection Direction { get; set; }
    }
}