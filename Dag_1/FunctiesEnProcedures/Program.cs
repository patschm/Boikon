using System;

namespace FunctiesEnProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] buf;
            FillArray(out buf);

            int a = 10;
            int b = 20;
            Console.WriteLine($"a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            var result = TelOpOpt(1, 2, d:3);
            ShowNumber(result);
        }

        // Procedures doen iets.
        // void NaamVanProcedure(int a1, string a2)
        // {}
        static void ShowNumber(int nr)
        {
            Console.WriteLine($"Het nummer is: {nr}");
        }
        static void ShowNumber(double nr)
        {
            Console.WriteLine($"Het nummer is: {nr}");
        }
        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static void FillArray(out byte[] buffer)
        {
            buffer = new byte[101];
            for(int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)i;
            }
        }


        // Functies doen ook iets, maar geven ook een resultaat terug
        // DataType NaamVanFunctie(int a, int b)
        // { ... }
        static int TelOp(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static double TelOp(double a, double b)
        {
            return a + b;
        }
        static int TelOp(params int[] nrs)
        {
            int sum = 0;
            for(int i = 0; i < nrs.Length; i++)
            {
                sum += nrs[i];
            }
            return sum;
        }
        static int TelOpOpt(int a, int b, int c = 0, int d = 10)
        {
            int sum = a + b + c + d;
            return sum;
        }


    }
}
