using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    class Werknemer: Persoon, IBoikonContract
    {
        public void Produceer()
        {
            Werkt();
        }

        public virtual void Werkt()
        {
            Console.WriteLine("De werknemer doet iets");
        }
    }
}
