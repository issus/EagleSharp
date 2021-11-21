using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Library
    {

        /// <remarks/>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <remarks/>
        [XmlElement("packages")]
        public Packages Packages { get; set; }

        /// <remarks/>
        [XmlElement("symbols")]
        public Symbols Symbols { get; set; }

        /// <remarks/>
        [XmlElement("devicesets")]
        public DeviceSets DeviceSets { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}