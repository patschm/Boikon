using System;
using System.Collections.Generic;
using System.Text;

namespace Motor
{
    class ServoMotor
    {
        private float snelheid = 100;

        public Encoder Encoder { get; set; } = Encoder.Incremental;
        public Direction Direction 
        { 
            get
            {
                if (Snelheid < 0) return Direction.CounterClockWise;
                if (Snelheid > 0) return Direction.ClockWise;
                return Direction.None;
            }
        } 
        public float Snelheid
        {
            get { return Math.Abs(snelheid); }
            set
            {
                if (value >= -250 && value < 250)
                {
                    snelheid = value;
                }
            }
        }

        public void Aan()
        {
            Console.WriteLine($"De motor loopt in {Direction} richting met een snelheid van {Snelheid} iets/s");
        }
        public void Uit()
        {
            Snelheid = 0;
            Console.WriteLine("De motor staat uit");
        }
    }
}
