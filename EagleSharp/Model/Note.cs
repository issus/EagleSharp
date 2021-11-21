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
     
    public partial class Note
    {

        /// <remarks/>
        [XmlAttribute("version")]
        public string Version { get; set; }

        /// <remarks/>
        [XmlAttribute("severity")]
        public NoteSeverity Severity { get; set; }

        /// <remarks/>
        [XmlText()]
        [XmlElement("note")]
        public string Value { get; set; }
    }
}