using System;
using System.Collections.Generic;
using System.Text;

namespace Interactie_Deel_2
{
    delegate void Bla(int bliep);

    class Martijn
    {
        public void VoerUit(Bla functie)
        {
            Console.WriteLine("Martijn voert het volgende uit:");
            functie(42);
        }

    }
}
