using System;
using System.Collections.Generic;
using System.Text;

namespace MotorRevisie
{
    class BrandstofMotor: Motor
    {
        public int Cylinders { get; set; } = 6;

        public void Gas(int amount)
        {
            CurrentSpeed += amount;
            Console.WriteLine($"Versnel naar {CurrentSpeed}");
        }
        public void Rem(int amount)
        {
            CurrentSpeed -= amount;
            if (CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
            Console.WriteLine($"Rem naar {CurrentSpeed}");
        }
        public override void Start()
        {
            Console.WriteLine("De verbrandingsmotor start");
        }
        public override void Stop()
        {
            Console.WriteLine("De verbrandingsmotor stopt");

        }
    }
}
