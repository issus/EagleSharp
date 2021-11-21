using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Attributes
    {
        /// <remarks/>
        [XmlElement("attribute")]
        public Attribute[] Attribute { get; set; }
    }
}