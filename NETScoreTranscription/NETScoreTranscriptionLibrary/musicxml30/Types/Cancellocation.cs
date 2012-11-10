using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "cancel-location")]
    public enum Cancellocation
    {
        /// <remarks />
        left,

        /// <remarks />
        right,

        /// <remarks />
        [XmlEnum("before-barline")] beforebarline,
    }
}