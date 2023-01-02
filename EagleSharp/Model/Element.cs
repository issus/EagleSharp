using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Element
    {
        public Element()
        {
            this.Locked = ElementLocked.no;
            this.Populate = ElementPopulate.yes;
            this.Smashed = ElementSmashed.no;
            this.Rot = "R0";
        }

        /// <remarks/>
        [XmlElement("attribute")]
        public Attribute[] Attribute { get; set; }

        /// <remarks/>
        [XmlElement("variant")]
        public Variant[] Variant { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("library")]
        public string Library { get; set; }

        /// <remarks/>
        [XmlAttribute("package")]
        public string Package { get; set; }

        /// <remarks/>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("locked")]
        [System.ComponentModel.DefaultValueAttribute(ElementLocked.no)]
        public ElementLocked Locked { get; set; }

        /// <remarks/>
        [XmlAttribute("populate")]
        [System.ComponentModel.DefaultValueAttribute(ElementPopulate.yes)]
        public ElementPopulate Populate { get; set; }

        /// <remarks/>
        [XmlAttribute("smashed")]
        [System.ComponentModel.DefaultValueAttribute(ElementSmashed.no)]
        public ElementSmashed Smashed { get; set; }

        /// <remarks/>
        [XmlAttribute("rot")]
        [System.ComponentModel.DefaultValueAttribute("R0")]
        public string Rot { get; set; }
        }
}