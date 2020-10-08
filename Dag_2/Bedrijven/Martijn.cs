using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    class Martijn : Werknemer
    {
        public override void Werkt()
        {
            DoeIets();
        }
        public void DoeIets()
        {
            Console.WriteLine("Martijn doet niets");
        }
    }
}
