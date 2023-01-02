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
     
    public partial class Rectangle
    {
        public Rectangle()
        {
            Rot = "R0";
        }

        /// <remarks/>
        [XmlAttribute("x1")]
        public string X1 { get; set; }

        /// <remarks/>
        [XmlAttribute("y1")]
        public string Y1 { get; set; }

        /// <remarks/>
        [XmlAttribute("x2")]
        public string X2 { get; set; }

        /// <remarks/>
        [XmlAttribute("y2")]
        public string Y2 { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [DefaultValue("R0")]
        public string Rot { get; set; }
    }
}