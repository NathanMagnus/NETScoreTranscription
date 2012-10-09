using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETScoreTranscriptionLibrary.DataTypes
{
    public class MusicXMLString
    {
        private int _min;
        private int _max;
        public String Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value.Length < _min || value.Length > _max)
                    throw new Exception("Range is < " + _min + " or > " + _max + ".");
            }
        }
        private String _value;

        public MusicXMLString(int min, int max)
        {
            _min = min;
            _max = max;
        }
    }

    public class NumberOrNormal
    {
        public String Normal
        {
            get { return _normal; }
            set
            {
                _number = null;
                _normal = value;
            }
        }
        private String _normal;

        public Decimal? Number
        {
            get { return _number; }
            set
            {
                _normal = null; 
                _number = value;
            }
        }
        private Decimal? _number;
    }
}
