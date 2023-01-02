using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class ModuleInsts
    {
        /// <remarks/>
        [XmlElement("moduleinst")]
        public ModuleInst[] ModuleInst { get; set; }
    }
}