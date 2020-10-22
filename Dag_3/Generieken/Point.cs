using System;
using System.Collections.Generic;
using System.Text;

namespace Generieken
{
    class Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
