using System.ComponentModel;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Clearance
    {
        public Clearance()
        {
            Value = "0";
        }

        /// <remarks/>
        [XmlAttribute("class")]
        public string Class { get; set; }

        /// <remarks/>
        [XmlAttribute("value")]
        [DefaultValue("0")]
        public string Value { get; set; }
    }
}