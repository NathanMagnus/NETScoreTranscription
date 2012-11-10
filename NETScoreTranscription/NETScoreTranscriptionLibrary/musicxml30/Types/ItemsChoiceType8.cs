using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType8
    {
        /// <remarks />
        cancel,

        /// <remarks />
        fifths,

        /// <remarks />
        [XmlEnum("key-accidental")] keyaccidental,

        /// <remarks />
        [XmlEnum("key-alter")] keyalter,

        /// <remarks />
        [XmlEnum("key-step")] keystep,

        /// <remarks />
        mode,
    }
}