using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Threading;

namespace NETScoreTranscription
{
    public class Score : System.Windows.Controls.Canvas, IScoreObject
    {
        #region Parameters

        /// <summary>
        /// List of score objects for this score
        /// </summary>
        public IList<IScoreObject> ScoreObjects
        {
            get;
            private set;
        }
        #endregion

        public Score()
        {

        }
    }
}
