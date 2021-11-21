using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Compatibility
    {
        /// <remarks/>
        [XmlElement("note")]
        public Note[] Note { get; set; }
    }
}