using System;
using System.Diagnostics;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Alle elementen van hetzelfde type
            // Moet een bepaalde lengte hebben
            // Aaneen gesloten geheugen
            // Array initialiseren wordt gevuld met default waardes
            // Arrays zijn immutable (in size)

            int[] rijtje = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            rijtje[0] = 2;
            Console.WriteLine(rijtje.Length);

            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(matrix[0,2]);

            int[,,] kubus = new int[3,3,3];

            int[][] jagged = new int[3][];
            jagged[0] = new int[5];
            jagged[1] = new int[10];

            jagged[1][0] = 7;

            for(int i = 0; i < rijtje.Length; i++)
            {
                int tmp = rijtje[i];
                Console.WriteLine(tmp);
            }

            // Iterator design pattern (Enumerator)
            foreach(int tmp in rijtje)
            {
                Console.WriteLine(tmp);
            }

            //string s = "";
            //StringBuilder bld = new StringBuilder();
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for(int i = 0; i < 80000; i++)
            //{
            //    bld.Append(i);
            //    //s += i;
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            Console.ReadLine();
        }
    }
}
