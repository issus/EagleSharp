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
     
    public partial class PortRef
    {
        /// <remarks/>
        [XmlAttribute("moduleinst")]
        public string ModuleInst { get; set; }

        /// <remarks/>
        [XmlAttribute("port")]
        public string Port { get; set; }
    }
}