using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Pass
    {

        public Pass()
        {
            Active = PassActive.yes;
        }

        /// <remarks/>
        [XmlElement("param")]
        public Param[] Param { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("refer")]
        public string Refer { get; set; }

        /// <remarks/>
        [XmlAttribute("active")]
        [System.ComponentModel.DefaultValueAttribute(PassActive.yes)]
        public PassActive Active { get; set; }
    }
}