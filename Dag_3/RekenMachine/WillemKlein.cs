using System;
using System.Collections.Generic;
using System.Text;

namespace RekenMachine
{
    class WillemKlein
    {
        public void Reken(MathDel berekening, int a, int b)
        {
            Console.WriteLine("Willem Klein rekent nu...");
            int result = berekening(a, b);
            // TODO: Rekenen
            Console.WriteLine($"Het resultaat is: {result}");
        }
    }
}
