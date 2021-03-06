﻿using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType10
    {
        /// <remarks />
        [XmlEnum("beat-type")] beattype,

        /// <remarks />
        beats,

        /// <remarks />
        interchangeable,

        /// <remarks />
        [XmlEnum("senza-misura")] senzamisura,
    }
}