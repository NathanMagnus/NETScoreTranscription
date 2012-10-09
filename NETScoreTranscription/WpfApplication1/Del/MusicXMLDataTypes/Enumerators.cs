using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace NETScoreTranscriptionLibrary.DataTypes
{
    //todo: comma-separated-text
    public enum AboveBelow { ABOVE, BELOW };
    public enum CssFontSize { XXSMALL, XSMALL, SMALL, MEDIUM, LARGE, XLARGE, XXLARGE };
    public enum EnclosureShape { RECTANGLE, SQUARE, OVAL, CIRCLE, BRACKET, TRIANGLE, DIAMOND, NONE };
    public enum FermataShape { NORMAL, ANGLED, SQUARE, BLANK };
    public enum FontStyle { NORMAL, ITALIC };
    public enum FontWeight { NORMAL, BOLD };
    public enum LeftCenterRight { LEFT, CENTER, RIGHT };
    public enum LeftRight { LEFT, RIGHT };
    public enum LineShape { STRAIGHT, CURVED };
    public enum LineType { SOLID, DASHED, DOTTED, WAVY };
    public enum Mute { ON, OFF, SRAIGHT, CUP, HARMON_NO_STEM, HARMON_STEM, BUCKET, PLUNGER, HAT, SOLOTONE, PRACTICE, STOP_MUTED, STOP_HAND, ECHO, PALM };
    public enum OverUnder { OVER, UNDER };
    public enum SemiPitched { HIGH, MEDIUM_HIGH, MEDIUM, MEDIUM_LOW, LOW, VERY_LOW };
    public enum StartNote { UPPER, MAIN, BELOW };
    public enum StartStop { START, STOP };
    public enum StartStopContinue { START, STOP, CONTINUE };
    public enum StartStopSingle { START, STOP, SINGLE };
    public enum SymbolSize { FULL, CUE, LARGE };
    public enum TextDirection { LEFT_TO_RIGHT, RIGHT_TO_LEFT, LEFT_TO_RIGHT_BIDI_OVERRIDE, RIGHT_TO_LEFT_BIDI_OVERRIDE };
    public enum TopBottom { TOP, BOTTOM };
    public enum TrillStep { WHOLE, HALF, UNISON };
    public enum TwoNoteturn { WHOLE, HALF, NONE };
    public enum UpDown { UP, DOWN };
    public enum NoteLetters { A, B, C, D, E, F, G };
    //left off upright-inverted
}
