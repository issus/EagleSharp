using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Errors
    {
        /// <remarks/>
        [XmlElement("approved")]
        public Approved[] Approved { get; set; }
    }
}