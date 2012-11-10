using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "arrow-direction")]
    public enum ArrowDirection
    {
        /// <remarks />
        left,

        /// <remarks />
        up,

        /// <remarks />
        right,

        /// <remarks />
        down,

        /// <remarks />
        northwest,

        /// <remarks />
        northeast,

        /// <remarks />
        southeast,

        /// <remarks />
        southwest,

        /// <remarks />
        [XmlEnum("left right")] leftright,

        /// <remarks />
        [XmlEnum("up down")] updown,

        /// <remarks />
        [XmlEnum("northwest southeast")] northwestsoutheast,

        /// <remarks />
        [XmlEnum("northeast southwest")] northeastsouthwest,

        /// <remarks />
        other,
    }
}