using System.Drawing;

namespace oobc_statepattern
{
    public class Line
    {
        private readonly Point _start;
        private readonly Point _end;

        public Line(Point start, Point end)
        {
            _start = start;
            _end = end;
        }

        protected bool Equals(Line other)
        {
            return _start.Equals(other._start) && _end.Equals(other._end);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Line) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_start.GetHashCode()*397) ^ _end.GetHashCode();
            }
        }

        public override string ToString()
        {
            return string.Format("Start: {0}, End: {1}", _start, _end);
        }
    }
}