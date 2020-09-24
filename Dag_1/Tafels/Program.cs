using System;

namespace Tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int tafel = 1; tafel <= 10; tafel++)
            {
                Console.WriteLine("De tafel van " + tafel);
                //Console.WriteLine($"De tafel van {tafel}");
                for (int teller = 1; teller <= 10; teller++)
                {
                    //Console.WriteLine("{0, -2} x {1, -2} = {2}", teller, tafel, teller * tafel);
                    Console.WriteLine($"{teller, -2} x {tafel, -2} = {teller * tafel}");
                }
            }
        }
    }
}
