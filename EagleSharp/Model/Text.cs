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
     
    public partial class Text
    {
        public Text()
        {
            Font = TextFont.proportional;
            Ratio = "8";
            Rot = "R0";
            Align = TextAlign.bottomleft;
            Distance = "50";
        }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("size")]
        public string Size { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("font")]
        [DefaultValue(TextFont.proportional)]
        public TextFont Font { get; set; }

        /// <remarks/>
        [XmlAttribute("ratio")]
        [DefaultValue("8")]
        public string Ratio { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [DefaultValue("R0")]
        public string Rot { get; set; }

        /// <remarks/>
        [XmlAttribute("align")]
        [DefaultValue(TextAlign.bottomleft)]
        public TextAlign Align { get; set; }

        /// <remarks/>
        [XmlAttribute("distance")]
        [DefaultValue("50")]
        public string Distance { get; set; }

        /// <remarks/>
        [XmlText()]
        [XmlElement("value")]
        public string Value { get; set; }
    }
}