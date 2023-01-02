﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OriginalCircuit.EagleSharp.Model
{
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "")]
     
    public partial class VariantDefs
    {
        /// <remarks/>
        [XmlElement("variantdef")]
        public VariantDef[] VariantDef { get; set; }
    }
}