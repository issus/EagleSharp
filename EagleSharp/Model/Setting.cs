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
     
    public partial class Setting
    {
        public Setting()
        {
            VerticalText = SettingVerticaltText.up;
        }

        /// <remarks/>
        [XmlAttribute("alwaysvectorfont")]
        public SettingAlwaysVectorFont AlwaysVectorFont { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool AlwaysVectorFontSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("verticaltext")]
        [DefaultValue(SettingVerticaltText.up)]
        public SettingVerticaltText VerticalText { get; set; }
    }
}