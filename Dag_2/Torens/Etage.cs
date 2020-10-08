using System;
using System.Collections.Generic;
using System.Text;

namespace Torens
{
    class Etage
    {
        public int EtageNummer { get; set; }
        
        // Statics zijn gedeelde members
        // Ze behoren niet toe aan 1 object, maar aan alle
        // this heeft geen betekenis voor static members
        // Ze worden ook wel class members genoemd
        public static Lift Elevator { get; set; } = new Lift();

        public void CallElevator()
        {
            Etage.Elevator.Call(EtageNummer);
        }
        public void ShowElevatorStatus()
        {
            Console.WriteLine($"Elevator staat op de {Elevator.CurrentFloor}e");
        }
    }
}
