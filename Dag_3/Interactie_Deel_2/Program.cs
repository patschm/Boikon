using System;

namespace Interactie_Deel_2
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Martijn m1 = new Martijn();
            Patrick p1 = new Patrick();

            //p1.HaalBrood();

            m1.VoerUit(p1.HaalBrood);
            m1.VoerUit(Ontplof);

        }

        static void Ontplof(int xkeer)
        {
            Console.WriteLine($"Explodeert {xkeer} keer");
        }
    }
}
