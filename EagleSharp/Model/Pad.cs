using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Pad
    {

        public Pad()
        {
            Diameter = "0";
            Shape = PadShape.round;
            Rot = "R0";
            Stop = PadStop.yes;
            Thermals = PadThermals.yes;
            First = PadFirst.no;
        }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("drill")]
        public string Drill { get; set; }

        /// <remarks/>
        [XmlAttribute("diameter")]
        [DefaultValue("0")]
        public string Diameter { get; set; }

        /// <remarks/>
        [XmlAttribute("shape")]
        [DefaultValue(PadShape.round)]
        public PadShape Shape { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [DefaultValue("R0")]
        public string Rot { get; set; }

        /// <remarks/>
        [XmlAttribute("stop")]
        [DefaultValue(PadStop.yes)]
        public PadStop Stop { get; set; }

        /// <remarks/>
        [XmlAttribute("thermals")]
        [DefaultValue(PadThermals.yes)]
        public PadThermals Thermals { get; set; }

        /// <remarks/>
        [XmlAttribute("first")]
        [DefaultValue(PadFirst.no)]
        public PadFirst First { get; set; }
    }
}