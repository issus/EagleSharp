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
     
    public partial class SMD
    {
        public SMD()
        {
            Roundness = "0";
            Rot = "R0";
            Stop = SmdStop.yes;
            Thermals = SmdThermals.yes;
            Cream = SmdCream.yes;
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
        [XmlAttribute("dx")]
        public string DX { get; set; }

        /// <remarks/>
        [XmlAttribute("dy")]
        public string DY { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("roundness")]
        [DefaultValue("0")]
        public string Roundness { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [DefaultValue("R0")]
        public string Rot { get; set; }

        /// <remarks/>
        [XmlAttribute("stop")]
        [DefaultValue(SmdStop.yes)]
        public SmdStop Stop { get; set; }

        /// <remarks/>
        [XmlAttribute("thermals")]
        [DefaultValue(SmdThermals.yes)]
        public SmdThermals Thermals { get; set; }

        /// <remarks/>
        [XmlAttribute("cream")]
        [DefaultValue(SmdCream.yes)]
        public SmdCream Cream { get; set; }
    }
}