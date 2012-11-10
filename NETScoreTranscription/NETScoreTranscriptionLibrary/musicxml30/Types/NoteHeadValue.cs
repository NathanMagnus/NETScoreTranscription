using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.musicxml30.Types
{
    [GeneratedCode("System.Xml", "4.0.30319.233")]
    [Serializable]
    [XmlType(TypeName = "noteHead-value")]
    public enum NoteHeadValue
    {
        /// <remarks />
        slash,

        /// <remarks />
        triangle,

        /// <remarks />
        diamond,

        /// <remarks />
        square,

        /// <remarks />
        cross,

        /// <remarks />
        x,

        /// <remarks />
        [XmlEnum("circle-x")] circlex,

        /// <remarks />
        [XmlEnum("inverted triangle")] invertedtriangle,

        /// <remarks />
        [XmlEnum("arrow down")] arrowdown,

        /// <remarks />
        [XmlEnum("arrow up")] arrowup,

        /// <remarks />
        slashed,

        /// <remarks />
        [XmlEnum("back slashed")] backslashed,

        /// <remarks />
        normal,

        /// <remarks />
        cluster,

        /// <remarks />
        [XmlEnum("circle dot")] circledot,

        /// <remarks />
        [XmlEnum("left triangle")] lefttriangle,

        /// <remarks />
        rectangle,

        /// <remarks />
        none,

        /// <remarks />
        @do,

        /// <remarks />
        re,

        /// <remarks />
        mi,

        /// <remarks />
        fa,

        /// <remarks />
        [XmlEnum("fa up")] faup,

        /// <remarks />
        so,

        /// <remarks />
        la,

        /// <remarks />
        ti,
    }
}