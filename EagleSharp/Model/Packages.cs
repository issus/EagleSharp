using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Packages
    {
        /// <remarks/>
        [XmlElement("package")]
        public Package[] Package { get; set; }
    }
}