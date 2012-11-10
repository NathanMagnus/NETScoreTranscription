using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "degree-symbol-value")]
    public enum DegreeSymbolValue
    {
        /// <remarks />
        major,

        /// <remarks />
        minor,

        /// <remarks />
        augmented,

        /// <remarks />
        diminished,

        /// <remarks />
        [XmlEnum("half-diminished")] halfdiminished,
    }
}