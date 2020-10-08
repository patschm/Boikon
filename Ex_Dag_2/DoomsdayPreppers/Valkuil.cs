using IEEE;
using System;

namespace DoomsdayPreppers
{
    public class Valkuil : IDetectable
    {
        public void Activate()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("Valkuil met scherpe punten opent");
        }
    }
}
