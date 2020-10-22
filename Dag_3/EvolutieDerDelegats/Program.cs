using System;

namespace EvolutieDerDelegats
{
    delegate int MathDel(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            int c = 100;
            // Framework 1.0/1.1 (2002, 2003)
            MathDel m1 = new MathDel(Add);
            int res = m1(1, 2);

            // Framework 2.0 (2005)
            MathDel m2 = Add;
            res = m2(2, 3);

            // Nieuw!!!!! Inline functies
            MathDel m3 = delegate (int a, int b)
           {
               return a + b;
           };
            res = m3(3, 4);

            // Framework 3.0 (2008)
            // Lambda expressions
            MathDel m4 = (a, b) =>a + b;
            res = m4(4, 5);

            // Procedures
            Action<string> a1 = Console.WriteLine;
            //a1(res.ToString());

            // Functions
            Func<int, int, int> m5 = Add;
            res = m5(5, 6);

            Func<int, int, int> m6 = (a, b) => a - b;
            res = m6(7, 8);

            // 2018 (C# 8.0)
            int InlineAdd(int a, int b)
            {
                return a + b;
            }

            res = InlineAdd(6, 7);

            Console.WriteLine(res);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
