using System.ComponentModel;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Class
    {
        public Class()
        {
            Width = "0";
            Drill = "0";
        }

        /// <remarks/>
        [XmlElement("clearance")]
        public Clearance[] Clearance { get; set; }

        /// <remarks/>
        [XmlAttribute("number")]
        public string Number { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("width")]
        [DefaultValue("0")]
        public string Width { get; set; }

        /// <remarks/>
        [XmlAttribute("drill")]
        [DefaultValue("0")]
        public string Drill { get; set; }
    }
}