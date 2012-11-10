using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "beam-value")]
    public enum BeamValue
    {
        /// <remarks />
        begin,

        /// <remarks />
        @continue,

        /// <remarks />
        end,

        /// <remarks />
        [XmlEnum("forward hook")] forwardhook,

        /// <remarks />
        [XmlEnum("backward hook")] backwardhook,
    }
}