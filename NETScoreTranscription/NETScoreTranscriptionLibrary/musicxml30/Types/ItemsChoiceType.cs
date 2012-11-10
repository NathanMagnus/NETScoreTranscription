using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        /// <remarks />
        encoder,

        /// <remarks />
        [XmlEnum("encoding-date")] encodingdate,

        /// <remarks />
        [XmlEnum("encoding-description")] encodingdescription,

        /// <remarks />
        software,

        /// <remarks />
        supports,
    }
}