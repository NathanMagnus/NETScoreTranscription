using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscriptionLibrary.musicxml30.Types;

namespace NETScoreTranscriptionLibrary
{
    class PitchComparer : IComparer<Pitch>
    {
        public int Compare(musicxml30.Types.Pitch x, musicxml30.Types.Pitch y)
        {
            return CompareStatic(x, y);
        }

        public static int CompareStatic(Pitch x, Pitch y)
        {
            if(x.octave == y.octave)
                return ((int) x.step - (int) y.step);
            return int.Parse(x.octave) - int.Parse(y.octave);
        }
    }
}
