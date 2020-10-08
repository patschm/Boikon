using DoomsdayPreppers;
using Heras;
using IEEE;
using Infrac;
using Philips;
using System;

namespace MijnErf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Design Pattern
            // Observable design pattern

            DetectieLus lus = new DetectieLus();
            Hek gate = new Hek();
            gate.Open();
            Lamp tl = new Lamp();
            IDetectable kuil = new Valkuil();

            // Moet meer gebeuren
            lus.Connect(gate);
            lus.Connect(tl);
            lus.Connect(kuil);


            lus.Trigger();

            // De volgende oplossing telt niet!!!!!
            //tl.Aan();
            //kuil.Open();
            //gate.Open();
        }
    }
}
