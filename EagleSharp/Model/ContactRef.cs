using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class ContactRef
    {

        public ContactRef()
        {
            Route = ContactRefRoute.all;
            RouteTag = "";
        }

        /// <remarks/>
        [XmlAttribute("element")]
        public string Element { get; set; }

        /// <remarks/>
        [XmlAttribute("pad")]
        public string Pad { get; set; }

        /// <remarks/>
        [XmlAttribute("route")]
        [System.ComponentModel.DefaultValueAttribute(ContactRefRoute.all)]
        public ContactRefRoute Route { get; set; }

        /// <remarks/>
        [XmlAttribute("routetag")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string RouteTag { get; set; }
    }
}