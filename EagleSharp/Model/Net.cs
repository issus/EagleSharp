using System.ComponentModel;
using System.Xml.Serialization;

namespace EagleSharp.Model
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Net
    {
        public Net() { Class = "0"; }

        /// <remarks/>
        [XmlArrayItem("segmnet", typeof(Segment), IsNullable = false)]
        public Segment[] Segments { get; set; }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("class")]
        [DefaultValue("0")]
        public string Class { get; set; }
    }
}