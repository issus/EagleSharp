using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace EagleSharp.Model
{
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class VariantDef
    {
        public VariantDef()
        {
            Current = VariantDefCurrent.no;
        }

        /// <remarks/>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <remarks/>
        [XmlAttribute("current")]
        [DefaultValue(VariantDefCurrent.no)]
        public VariantDefCurrent Current { get; set; }
    }
}