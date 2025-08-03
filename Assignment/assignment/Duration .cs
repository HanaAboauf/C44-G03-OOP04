using System;

namespace oop04.assignment
{
    internal class Duration
    {
        #region Attributes
        private int hours;
        private int minutes;
        private int seconds;
        #endregion

        #region Properties
        public int Hours
        {
            get => hours;
            set => hours = value >= 0 ? value : 0;
        }

        public int Minutes
        {
            get => minutes;
            set => minutes = (value >= 0 && value < 60) ? value : 0;
        }

        public int Seconds
        {
            get => seconds;
            set => seconds = (value >= 0 && value < 60) ? value : 0;
        }
        #endregion

        #region Constructors
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Duration(int hours, int minutes, int seconds)
        {
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            SetFromTotalSeconds(totalSeconds);
        }

        public Duration(int totalSeconds)
        {
            SetFromTotalSeconds(totalSeconds);
        }

        private void SetFromTotalSeconds(int totalSeconds)
        {
            if (totalSeconds < 0)
                totalSeconds = 0;

            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string output = "";
            if (Hours > 0)
                output += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0)
                output += $"Minutes: {Minutes}, ";
            output += $"Seconds: {Seconds}";
            return output;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Duration other)
                return false;

            return this.TotalSeconds() == other.TotalSeconds();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        #endregion

        #region Utility
        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        #endregion

        #region Operator Overloads
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() - d2.TotalSeconds());
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.TotalSeconds() - 60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        public static bool operator true(Duration d) => d.TotalSeconds() > 0;

        public static bool operator false(Duration d) => d.TotalSeconds() <= 0;

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        public static explicit operator Duration(DateTime dt)
        {
            return new Duration(dt.Hour, dt.Minute, dt.Second);
        }
        #endregion
    }
}
