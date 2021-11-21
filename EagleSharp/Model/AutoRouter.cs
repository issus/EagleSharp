using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class AutoRouter
    {
        /// <remarks/>
        [XmlElement("pass")]
        public Pass[] Pass { get; set; }
    }
}