using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "stick-location")]
    public enum StickLocation
    {
        /// <remarks />
        center,

        /// <remarks />
        rim,

        /// <remarks />
        [XmlEnum("cymbal bell")] cymbalbell,

        /// <remarks />
        [XmlEnum("cymbal edge")] cymbaledge,
    }
}