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
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "eagle")]
    public partial class Eagle
    {

        private Compatibility compatibilityField;

        /// <remarks/>
        [XmlElement("compatability", Order = 0)]
        public Compatibility Compatibility
        {
            get
            {
                return this.compatibilityField;
            }
            set
            {
                this.compatibilityField = value;
            }
        }

        /// <remarks/>
        [XmlElement("drawing", Order = 1)]
        public Drawing Drawing { get; set; }

        /// <remarks/>
        [XmlElement("compatibility", Order = 2)]
        public Compatibility Compatibility1
        {
            get
            {
                return this.compatibilityField;
            }
            set
            {
                this.compatibilityField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute("version")]
        public string Version { get; set; }
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum NoteSeverity
    {

        /// <remarks/>
        info,

        /// <remarks/>
        warning,

        /// <remarks/>
        error,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum SettingAlwaysVectorFont
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum SettingVerticaltText
    {

        /// <remarks/>
        up,

        /// <remarks/>
        down,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum GridUnitDist
    {

        /// <remarks/>
        mic,

        /// <remarks/>
        mm,

        /// <remarks/>
        mil,

        /// <remarks/>
        inch,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum GridUnit
    {

        /// <remarks/>
        mic,

        /// <remarks/>
        mm,

        /// <remarks/>
        mil,

        /// <remarks/>
        inch,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum GridStyle
    {

        /// <remarks/>
        lines,

        /// <remarks/>
        dots,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum GridDisplay
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum GridAltUnitDist
    {

        /// <remarks/>
        mic,

        /// <remarks/>
        mm,

        /// <remarks/>
        mil,

        /// <remarks/>
        inch,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum GridAltUnit
    {

        /// <remarks/>
        mic,

        /// <remarks/>
        mm,

        /// <remarks/>
        mil,

        /// <remarks/>
        inch,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum LayerVisible
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum LayerActive
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum DimensionDType
    {

        /// <remarks/>
        parallel,

        /// <remarks/>
        horizontal,

        /// <remarks/>
        vertical,

        /// <remarks/>
        radius,

        /// <remarks/>
        diameter,

        /// <remarks/>
        leader,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum DimensionUnit
    {

        /// <remarks/>
        mic,

        /// <remarks/>
        mm,

        /// <remarks/>
        mil,

        /// <remarks/>
        inch,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum DimensionVisible
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum FrameBorderLeft
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum FrameBorderTop
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum FrameBorderRight
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum FrameBorderBottom
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PolygonPour
    {

        /// <remarks/>
        solid,

        /// <remarks/>
        hatch,

        /// <remarks/>
        cutout,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PolygonOrphans
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PolygonThermals
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum TextFont
    {

        /// <remarks/>
        vector,

        /// <remarks/>
        proportional,

        /// <remarks/>
        @fixed,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum TextAlign
    {

        /// <remarks/>
        [XmlEnum("bottom-left")]
        bottomleft,

        /// <remarks/>
        [XmlEnum("bottom-center")]
        bottomcenter,

        /// <remarks/>
        [XmlEnum("bottom-right")]
        bottomright,

        /// <remarks/>
        [XmlEnum("center-left")]
        centerleft,

        /// <remarks/>
        center,

        /// <remarks/>
        [XmlEnum("center-right")]
        centerright,

        /// <remarks/>
        [XmlEnum("top-left")]
        topleft,

        /// <remarks/>
        [XmlEnum("top-center")]
        topcenter,

        /// <remarks/>
        [XmlEnum("top-right")]
        topright,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum WireStyle
    {

        /// <remarks/>
        continuous,

        /// <remarks/>
        longdash,

        /// <remarks/>
        shortdash,

        /// <remarks/>
        dashdot,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum WireCap
    {

        /// <remarks/>
        flat,

        /// <remarks/>
        round,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PadShape
    {

        /// <remarks/>
        square,

        /// <remarks/>
        round,

        /// <remarks/>
        octagon,

        /// <remarks/>
        @long,

        /// <remarks/>
        offset,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PadStop
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PadThermals
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PadFirst
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum SmdStop
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum SmdThermals
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum SmdCream
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PinVisible
    {

        /// <remarks/>
        off,

        /// <remarks/>
        pad,

        /// <remarks/>
        pin,

        /// <remarks/>
        both,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PinLength
    {

        /// <remarks/>
        point,

        /// <remarks/>
        @short,

        /// <remarks/>
        middle,

        /// <remarks/>
        @long,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PinDirection
    {

        /// <remarks/>
        nc,

        /// <remarks/>
        @in,

        /// <remarks/>
        @out,

        /// <remarks/>
        io,

        /// <remarks/>
        oc,

        /// <remarks/>
        pwr,

        /// <remarks/>
        pas,

        /// <remarks/>
        hiz,

        /// <remarks/>
        sup,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PinFunction
    {

        /// <remarks/>
        none,

        /// <remarks/>
        dot,

        /// <remarks/>
        clk,

        /// <remarks/>
        dotclk,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum GateAddLevel
    {

        /// <remarks/>
        must,

        /// <remarks/>
        can,

        /// <remarks/>
        next,

        /// <remarks/>
        request,

        /// <remarks/>
        always,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ConnectRoute
    {

        /// <remarks/>
        all,

        /// <remarks/>
        any,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum AttributeFont
    {

        /// <remarks/>
        vector,

        /// <remarks/>
        proportional,

        /// <remarks/>
        @fixed,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum AttributeDisplay
    {

        /// <remarks/>
        off,

        /// <remarks/>
        value,

        /// <remarks/>
        name,

        /// <remarks/>
        both,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum AttributeConstant
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum DeviceSetUserValue
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum VariantDefCurrent
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PassActive
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum VariantPopulate
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ElementLocked
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ElementPopulate
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ElementSmashed
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ContactRefRoute
    {

        /// <remarks/>
        all,

        /// <remarks/>
        any,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ViaShape
    {

        /// <remarks/>
        square,

        /// <remarks/>
        round,

        /// <remarks/>
        octagon,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ViaAlwaysStop
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum SignalAirWiresHidden
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum PortDirection
    {

        /// <remarks/>
        nc,

        /// <remarks/>
        @in,

        /// <remarks/>
        @out,

        /// <remarks/>
        io,

        /// <remarks/>
        oc,

        /// <remarks/>
        pwr,

        /// <remarks/>
        pas,

        /// <remarks/>
        hiz,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum ModuleInstSmashed
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum InstanceSmashed
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum LabelFont
    {

        /// <remarks/>
        vector,

        /// <remarks/>
        proportional,

        /// <remarks/>
        @fixed,
    }

    
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "")]
    public enum LabelXRef
    {

        /// <remarks/>
        no,

        /// <remarks/>
        yes,
    }
}