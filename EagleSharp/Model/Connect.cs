using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Connect
    {

        public Connect()
        {
            this.Route= ConnectRoute.all;
        }

        /// <remarks/>
        [XmlAttribute("gate")]
        public string Gate { get; set; }

        /// <remarks/>
        [XmlAttribute("pin")]
        public string Pin { get; set; }

        /// <remarks/>
        [XmlAttribute("pad")]
        public string Pad { get; set; }

        /// <remarks/>
        [XmlAttribute("route")]
        [System.ComponentModel.DefaultValueAttribute(ConnectRoute.all)]
        public ConnectRoute Route { get; set; }
    }
}