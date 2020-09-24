using System;
using MijnNS;
using MeTools;

namespace EigenType_1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            MijnNS.DagVanDeWeek day = MijnNS.DagVanDeWeek.Woensdag;
            Console.WriteLine(day);
            System.Int32 dag = 2;
        }
    }
}

namespace MijnNS
{
    // Custom type
    // enumeratie
    // Geeft betekenis aan een getal
    enum DagVanDeWeek : ulong
    {
        Zondag = 1,
        Maandag = 2,
        Dinsdag = 4,
        Woensdag = 8,
        Donderdag,
        Vrijdag,
        Zaterdag
    }
}
