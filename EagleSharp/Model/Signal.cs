using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Signal
    {

        public Signal()
        {
            Class = "0";
            AirWiresHidden = SignalAirWiresHidden.no;
        }

        /// <remarks/>
        [XmlElement("contactref", typeof(ContactRef))]
        [XmlElement("polygon", typeof(Polygon))]
        [XmlElement("via", typeof(Via))]
        [XmlElement("wire", typeof(Wire))]
        public object[] Items { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("class")]
        [DefaultValue("0")]
        public string Class { get; set; }

        /// <remarks/>
        [XmlAttribute("airwireshidden")]
        [DefaultValue(SignalAirWiresHidden.no)]
        public SignalAirWiresHidden AirWiresHidden { get; set; }
    }
}