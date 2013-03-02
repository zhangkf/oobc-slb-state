using System;
using System.Drawing;

namespace oobc_statepattern
{
    public class PointParser
    {
        public static Point ParsePoint(string inputString)
        {
            var strings = inputString.Split(Convert.ToChar(","));
            return new Point(int.Parse(strings[0]), int.Parse(strings[1]));
        }
    }
}