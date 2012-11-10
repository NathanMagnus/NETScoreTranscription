using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscriptionLibrary.MusicXML30;
using NETScoreTranscriptionLibrary.musicxml30.Types;

namespace NETScoreTranscriptionLibrary
{
    public class Line
    {
        public IList<ScoreTimewiseMeasurePart> TimewiseMeasures = new List<ScoreTimewiseMeasurePart>();
    }
}
