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
     
    public partial class Via
    {
        public Via()
        {
            Diameter = "0";
            Shape = ViaShape.round;
            AlwaysStop = ViaAlwaysStop.no;
        }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("extent")]
        public string Extent { get; set; }

        /// <remarks/>
        [XmlAttribute("drill")]
        public string Drill { get; set; }

        /// <remarks/>
        [XmlAttribute("diameter")]
        [DefaultValue("0")]
        public string Diameter { get; set; }

        /// <remarks/>
        [XmlAttribute("shape")]
        [DefaultValue(ViaShape.round)]
        public ViaShape Shape { get; set; }

        /// <remarks/>
        [XmlAttribute("alwaysstop")]
        [DefaultValue(ViaAlwaysStop.no)]
        public ViaAlwaysStop AlwaysStop { get; set; }
    }
}