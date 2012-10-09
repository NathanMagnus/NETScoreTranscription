using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETScoreTranscriptionLibrary
{
    /*TODO: Render Process:
     * - Go through every measure and figure out the size required
     *  - Figure out space required to render each item in the list for the measure
     *   - Width affecting (clef, note, dot, flat, etc) and height affecting (tie, slur, stem, clef, key sig, etc) items
     * - Separate into Lines
     *  - Each line must have same number of measures (based on width of page)
     *  - Each measure in a column must be same size
     *   - Re position each element in measure at this point
     *  - Each line must have the same height
     * - Separate into pages
     *  - Based on height of lines and height of page
     * - Functions
     *  - Change color of item / range
     *   - Should this trigger an update?
     *   - What is the best way to pass this change back out?
     *  - Update drawing
     * - Draw
     *  - Return a canvas with everything drawn on it
     */

    /// <summary>
    /// Hold information relating to a single page of the score
    /// </summary>
    public class Page
    {
        public IList<Line> Lines { get; private set; }
    }
}
