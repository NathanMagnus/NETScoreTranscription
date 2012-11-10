using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(IncludeInSchema = false)]
    public enum Item1ChoiceType
    {
        /// <remarks />
        [XmlEnum("base-pitch")] basepitch,

        /// <remarks />
        [XmlEnum("sounding-pitch")] soundingpitch,

        /// <remarks />
        [XmlEnum("touching-pitch")] touchingpitch,
    }
}