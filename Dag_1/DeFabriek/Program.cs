using System;
using System.Security.Claims;

namespace DeFabriek
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp tl = new Lamp { Kleur = ConsoleColor.Cyan, Lumen = 230 }; // Property Initializer
            //tl.kleur = ConsoleColor.Yellow;
            //tl.lumen = 100;
            tl.Lumen = 500;
            Console.WriteLine(tl.Lumen);

            tl.Aan();
            Console.WriteLine("En er was licht");
            tl.Uit();
            Console.WriteLine("En weg");

            Lamp l2 = new Lamp { Lumen = 200 };
            l2.Aan();
        }
    }

}
