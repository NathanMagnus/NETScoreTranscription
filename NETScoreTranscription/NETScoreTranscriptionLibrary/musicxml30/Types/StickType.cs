using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "stick-type")]
    public enum StickType
    {
        /// <remarks />
        [XmlEnum("bass drum")] bassdrum,

        /// <remarks />
        [XmlEnum("double bass drum")] doublebassdrum,

        /// <remarks />
        timpani,

        /// <remarks />
        xylophone,

        /// <remarks />
        yarn,
    }
}