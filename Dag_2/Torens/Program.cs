using System;

namespace Torens
{
    class Program
    {
        static void Main(string[] args)
        {
            //42.SponsoredBy("ACME");
            string s = "Hallo";
            s.SponsoredBy("Boikon");


            Etage.Elevator.Call(67);

            Etage[] toren = new Etage[50];
            for(int i = 0; i < toren.Length; i++)
            {
                toren[i] = new Etage { EtageNummer = i };
            }

            toren[42].CallElevator();
            //toren[42].SponsoredBy("Heijmans");
            foreach(Etage et in toren)
            {
               // et.ShowElevatorStatus();
            }
            
        }

        static void DoeIest()
        {

        }
    }
}
