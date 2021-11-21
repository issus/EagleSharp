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
     
    public partial class Vertex
    {
        public Vertex()
        {
            Curve = "0";
        }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("curve")]
        [DefaultValue("0")]
        public string Curve { get; set; }
    }
}