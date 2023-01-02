using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Description
    {
        public Description()
        {
            Language = "en";
        }

        /// <remarks/>
        [XmlAttribute("language")]
        [System.ComponentModel.DefaultValueAttribute("en")]
        public string Language { get; set; }

        /// <remarks/>
        [XmlText()]
        public string Value { get; set; }
    }
}