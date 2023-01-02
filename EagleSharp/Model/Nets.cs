using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{

    [System.SerializableAttribute()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class Nets
    {

        /// <remarks/>
        [XmlElement("net")]
        public Net[] Net { get; set; }
    }
}