using System.Xml.Serialization;

namespace EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Gate
    {
        public Gate()
        {
            this.AddLevel = GateAddLevel.next;
            this.SwapLevel = "0";
        }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }

        /// <remarks/>
        [XmlAttribute("x")]
        public string X { get; set; }

        /// <remarks/>
        [XmlAttribute("y")]
        public string Y { get; set; }

        /// <remarks/>
        [XmlAttribute("addlevel")]
        [System.ComponentModel.DefaultValueAttribute(GateAddLevel.next)]
        public GateAddLevel AddLevel { get; set; }

        /// <remarks/>
        [XmlAttribute("swaplevel")]
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string SwapLevel { get; set; }
    }
}