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
     
    public partial class Pin
    {

        public Pin()
        {
            Visible = PinVisible.both;
            Length = PinLength.@long;
            Direction = PinDirection.io;
            Function = PinFunction.none;
            SwapLevel = "0";
            Rot = "R0";
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
        [XmlAttribute("visible")]
        [DefaultValue(PinVisible.both)]
        public PinVisible Visible { get; set; }

        /// <remarks/>
        [XmlAttribute("length")]
        [DefaultValue(PinLength.@long)]
        public PinLength Length { get; set; }

        /// <remarks/>
        [XmlAttribute("direction")]
        [DefaultValue(PinDirection.io)]
        public PinDirection Direction { get; set; }

        /// <remarks/>
        [XmlAttribute("function")]
        [DefaultValue(PinFunction.none)]
        public PinFunction Function { get; set; }

        /// <remarks/>
        [XmlAttribute("swaplevel")]
        [DefaultValue("0")]
        public string SwapLevel { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [DefaultValue("R0")]
        public string Rot { get; set; }
    }
}