using System;

namespace Bedrijven
{
    class Program
    {
        static void Main(string[] args)
        {
            Hans p3 = new Hans();
            Atze p2 = new Atze();
            Boikon comp = new Boikon();
            Martijn p1 = new Martijn();
            Bokito p4 = new Bokito();
            Robotje r1 = new Robotje();
            Matthijs p5 = new Matthijs();

            comp.Hire(p5);

            comp.Hire(r1);
            comp.Hire(p1);
            comp.Hire(p3);
            comp.Hire(p2);
            comp.Hire(p4);

            comp.Produceer();
        }
    }
}
