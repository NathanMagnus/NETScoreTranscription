using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "beater-value")]
    public enum BeaterValue
    {
        /// <remarks />
        Bow,

        /// <remarks />
        [XmlEnum("chime hammer")] ChimeHammer,

        /// <remarks />
        Coin,

        /// <remarks />
        Finger,

        /// <remarks />
        Fingernail,

        /// <remarks />
        Fist,

        /// <remarks />
        [XmlEnum("guiro scraper")] GuiroScraper,

        /// <remarks />
        Hammer,

        /// <remarks />
        Hand,

        /// <remarks />
        [XmlEnum("jazz stick")] JazzStick,

        /// <remarks />
        [XmlEnum("knitting needle")] Knitt
            ingNeedle,

        /// <remarks />
        [XmlEnum("metal hammer")] MetalHammer,

        /// <remarks />
        [XmlEnum("snare stick")] SnareStick,

        /// <remarks />
        [XmlEnum("spoon mallet")] SpoonMallet,

        /// <remarks />
        [XmlEnum("triangle beater")] TriangleBeater,

        /// <remarks />
        [XmlEnum("triangle beater plain")] TriangleBeaterPlain,

        /// <remarks />
        [XmlEnum("wire brush")] WireBrush,
    }
}