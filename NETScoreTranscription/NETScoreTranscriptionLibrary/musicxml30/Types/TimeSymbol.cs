using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "time-symbol")]
    public enum TimeSymbol
    {
        /// <remarks />
        common,

        /// <remarks />
        cut,

        /// <remarks />
        [XmlEnum("single-number")] singlenumber,

        /// <remarks />
        note,

        /// <remarks />
        [XmlEnum("dotted-note")] dottednote,

        /// <remarks />
        normal,
    }
}