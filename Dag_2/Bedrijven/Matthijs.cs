using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    class Matthijs : IBoikonContract, IFormattable
    {
        public void Produceer()
        {
            Console.WriteLine("Matthijs produceert wat");
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return "Matthijs";
        }
    }
}
