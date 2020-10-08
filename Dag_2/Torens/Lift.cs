using System;

namespace Torens
{
    class Lift
    {
        public int CurrentFloor { get; set; }

        public void Call(int target)
        {
            Console.WriteLine("Lift komt eraan");
            CurrentFloor = target;
        }

    }
}