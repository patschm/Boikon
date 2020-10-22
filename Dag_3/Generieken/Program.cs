using System;
using System.Collections;
using System.Collections.Generic;

namespace Generieken
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<float> p1 = new Point<float> { X = 10F, Y = 20F };
            Console.WriteLine(p1);

            // ArrayList list = new ArrayList();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            int y = 100;
            object oy = y; // boxing



            foreach(int nr in list)
            {
                Console.WriteLine(nr);
            }


            string a = "10.2";
            string b = "20.0";
            Console.WriteLine($"a={a}, b={b}");
            Swap<string>(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");
        }

        private static void Swap<Thee>(ref Thee aa, ref Thee bb) where Thee: ICloneable
        {
            Thee tmp = bb;
            bb = aa;
            aa = tmp;
        }
        private static void Swap(ref float aa, ref float bb)
        {
            float tmp = bb;
            bb = aa;
            aa = tmp;
        }
        private static void Swap(ref long aa, ref long bb)
        {
            long tmp = bb;
            bb = aa;
            aa = tmp;
        }
        private static void Swap(ref int aa, ref int bb)
        {
            int tmp = bb;
            bb = aa;
            aa = tmp;
        }
    }
}
