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
     
    public partial class Wire
    {
        public Wire()
        {
            Style = WireStyle.continuous;
            Curve = "0";
            Cap = WireCap.round;
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
        [XmlAttribute("width")]
        public string Width { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("extent")]
        public string Extent { get; set; }

        /// <remarks/>
        [XmlAttribute("style")]
        [DefaultValue(WireStyle.continuous)]
        public WireStyle Style { get; set; }

        /// <remarks/>
        [XmlAttribute("curve")]
        [DefaultValue("0")]
        public string Curve { get; set; }

        /// <remarks/>
        [XmlAttribute("cap")]
        [DefaultValue(WireCap.round)]
        public WireCap Cap { get; set; }
    }
}