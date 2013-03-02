using System.Collections.Generic;
using System.Drawing;

namespace oobc_statepattern
{
    public class LineDrawer
    {
        private List<Point> _points ;
        private const int LINE_POINTS_NUMBER = 2;

        public LineDrawer()
        {
            if (_points == null)
            {
                _points = new List<Point>(LINE_POINTS_NUMBER);
            }
        }

        public Line Draw()
        {
            return new Line(_points[0], _points[1]);
        }

        public void AddPoint(string inputString)
        {
            AddPoint(PointParser.ParsePoint(inputString));
        }

        private void AddPoint(Point point)
        {
            if (_points.Count < LINE_POINTS_NUMBER)
            {
                _points.Add(point);
            }
        }

    }
}