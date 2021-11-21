using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Layer
    {
        public Layer()
        {
            this.Visible = LayerVisible.yes;
            this.Active = LayerActive.yes;
        }

        /// <remarks/>
        [XmlAttribute("number")]
        public string Number { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("color")]
        public string Color { get; set; }

        /// <remarks/>
        [XmlAttribute("fill")]
        public string Fill { get; set; }

        /// <remarks/>
        [XmlAttribute("visible")]
        [System.ComponentModel.DefaultValueAttribute(LayerVisible.yes)]
        public LayerVisible Visible { get; set; }

        /// <remarks/>
        [XmlAttribute("active")]
        [System.ComponentModel.DefaultValueAttribute(LayerActive.yes)]
        public LayerActive Active { get; set; }
    }
}