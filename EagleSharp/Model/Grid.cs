using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Grid
    {
        public Grid()
        {
            this.style = GridStyle.lines;
            this.multiple = "1";
            this.display = GridDisplay.no;
        }

        /// <remarks/>
        [XmlAttribute("distance")]
        public string Distance { get; set; }

        /// <remarks/>
        [XmlAttribute("unitdist")]
        public GridUnitDist UnitDist { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitdistSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("unit")]
        public GridUnit unit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("style")]
        [System.ComponentModel.DefaultValueAttribute(GridStyle.lines)]
        public GridStyle style { get; set; }

        /// <remarks/>
        [XmlAttribute("multiple")]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public string multiple { get; set; }

        /// <remarks/>
        [XmlAttribute("display")]
        [System.ComponentModel.DefaultValueAttribute(GridDisplay.no)]
        public GridDisplay display { get; set; }

        /// <remarks/>
        [XmlAttribute("altdistance")]
        public string altdistance { get; set; }

        /// <remarks/>
        [XmlAttribute("altunitdist")]
        public GridAltUnitDist altunitdist { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altunitdistSpecified { get; set; }

        /// <remarks/>
        [XmlAttribute("altunit")]
        public GridAltUnit altunit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool altunitSpecified { get; set; }
    }
}