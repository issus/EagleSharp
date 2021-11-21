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
     
    public partial class PinRef
    {

        /// <remarks/>
        [XmlAttribute("part")]
        public string Part { get; set; }

        /// <remarks/>
        [XmlAttribute("gate")]
        public string Gate { get; set; }

        /// <remarks/>
        [XmlAttribute("pin")]
        public string Pin { get; set; }
    }
}