using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    class Atze : Werknemer
    {
        public override void Werkt()
        {
            WerktHard();
        }
        public void WerktHard()
        {
            Console.WriteLine("Niemand weet wat Atze doet");
        }
    }
}
