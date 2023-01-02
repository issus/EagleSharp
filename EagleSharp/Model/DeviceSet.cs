using System;
using System.Xml.Serialization;
using System.ComponentModel;

namespace OriginalCircuit.EagleSharp.Model
{
    [Serializable()]
    [System.Diagnostics.DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class DeviceSet
    {
        public DeviceSet()
        {
            this.Prefix = "";
            this.UserValue = DeviceSetUserValue.no;
        }

        /// <remarks/>
        [XmlElement("description")]
        public Description Description { get; set; }

        /// <remarks/>
        [XmlElement("gates")]
        public Gates Gates { get; set; }

        /// <remarks/>
        [XmlElement("devices")]
        public Devices Devices { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("prefix")]
        [DefaultValue("")]
        public string Prefix { get; set; }

        /// <remarks/>
        [XmlAttribute("uservalue")]
        [DefaultValue(DeviceSetUserValue.no)]
        public DeviceSetUserValue UserValue { get; set; }
    }
}