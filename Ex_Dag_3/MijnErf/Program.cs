using DoomsdayPreppers;
using Heras;
using IEEE;
using Infrac;
using Philips;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace MijnErf
{
    class Program
    {
        static void Main(string[] args)
        {
            DetectieLus lus = new DetectieLus();
            Hek gate = new Hek();
            Lamp tl = new Lamp();
            Valkuil kuil = new Valkuil();

            lus.Connect(gate.Open);
            lus.Connect(tl.Aan);
            lus.Connect(kuil.Open);
           
            lus.Connect(gate);
            lus.Connect(tl);
            lus.Connect(kuil);

            lus.Detect += gate.Open;
            lus.Detect += tl.Aan;
            lus.Detect += kuil.Open;

            lus.Trigger();
        }
    }
}
