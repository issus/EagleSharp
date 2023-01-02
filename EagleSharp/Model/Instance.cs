using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Instance
    {
        public Instance()
        {
            this.Smashed = InstanceSmashed.no;
            this.Rot = "R0";
        }

        /// <remarks/>
        [XmlElement("attribute")]
        public Attribute[] Attribute { get; set; }

        /// <remarks/>
        [XmlAttribute("part")]
        public string Part { get; set; }

        /// <remarks/>
        [XmlAttribute("gate")]
        public string Gate { get; set; }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("smashed")]
        [System.ComponentModel.DefaultValueAttribute(InstanceSmashed.no)]
        public InstanceSmashed Smashed { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [System.ComponentModel.DefaultValueAttribute("R0")]
        public string Rot { get; set; }
    }
}