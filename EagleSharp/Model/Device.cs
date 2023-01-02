using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Device
    {
        public Device()
        {
            this.Name = "";
        }

        /// <remarks/>
        [XmlElement("connects")]
        public Connects Connects { get; set; }

        /// <remarks/>
        [XmlElement("technologies")]
        public Technologies Technologies { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        [System.ComponentModel.DefaultValue("")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("package")]
        public string Package { get; set; }
    }
}