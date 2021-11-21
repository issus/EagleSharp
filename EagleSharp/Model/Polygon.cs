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
     
    public partial class Polygon
    {
        public Polygon()
        {
            Pour = PolygonPour.solid;
            Orphans = PolygonOrphans.no;
            Thermals = PolygonThermals.yes;
            Rank = "0";
        }

        /// <remarks/>
        [XmlElement("vertex")]
        public Vertex[] Vertex { get; set; }

        /// <remarks/>
        [XmlAttribute("width")]
        public string Width { get; set; }

        /// <remarks/>
        [XmlAttribute("layer")]
        public string Layer { get; set; }

        /// <remarks/>
        [XmlAttribute("spacing")]
        public string Spacing { get; set; }

        /// <remarks/>
        [XmlAttribute("pour")]
        [DefaultValue(PolygonPour.solid)]
        public PolygonPour Pour { get; set; }

        /// <remarks/>
        [XmlAttribute("isolate")]
        public string Isolate { get; set; }

        /// <remarks/>
        [XmlAttribute("orphans")]
        [DefaultValue(PolygonOrphans.no)]
        public PolygonOrphans Orphans { get; set; }

        /// <remarks/>
        [XmlAttribute("thermals")]
        [DefaultValue(PolygonThermals.yes)]
        public PolygonThermals Thermals { get; set; }

        /// <remarks/>
        [XmlAttribute("rank")]
        [DefaultValue("0")]
        public string Rank { get; set; }
    }
}