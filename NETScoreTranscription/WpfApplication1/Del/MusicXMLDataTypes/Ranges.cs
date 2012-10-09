using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NETScoreTranscription;

namespace NETScoreTranscriptionLibrary.DataTypes
{
    public class Range<T> where T: IComparable<T>
    {
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value.CompareTo(_min) < 0 || value.CompareTo(_max) > 0)
                    throw new Exception("Range is < " + _min + " or > " + _max + ".");
            }
        }
        private T _value;
        private T _min;
        private T _max;

        public Range(T min, T max)
        {
            SetRange(min, max);
        }

        public void SetRange(T min, T max)
        {
            _min = min;
            _max = max;
        }
    }

    public class RangeOrNull<T> where T: IComparable<T>
    {
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value == null)
                    throw new Exception("Error that has yet to fixed");

                else if (value.CompareTo(_min) < 0 || value.CompareTo(_max) > 0)
                    throw new Exception("Range is < " + _min + " or > " + _max + ".");
            }
        }

        private T _value;
        private T _min;
        private T _max;

        public RangeOrNull(T min, T max)
        {
            SetRange(min, max);
        }

        public void SetRange(T min, T max)
        {
            _min = min;
            _max = max;
        }
    }
}
