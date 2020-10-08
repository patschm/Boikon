using System;
using System.Collections.Generic;
using System.Text;

namespace Map
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator+(Point px, Point py)
        {
            return new Point { X = px.X + py.X, Y = px.Y + py.Y };
        }

        public override string ToString()
        {
            return $"({X}, {Y})"; 
        }
    }
}
