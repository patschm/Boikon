using System;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 10, Y = 20 };
            Point p2 = new Point { X = 100, Y = 200 };

            Point p3 = p1 + p2;

            Console.WriteLine(p3);

            Console.WriteLine(p1);
            DoeIets(p1);
            Console.WriteLine(p1);
        }

        private static void DoeIets(Point ppp)
        {
            ppp.X = 1000;
            ppp.Y = 2000;
            Console.WriteLine(ppp);
        }
    }
}
