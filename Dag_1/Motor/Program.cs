using System;

namespace Motor
{
    class Program
    {
        static void Main(string[] args)
        {
            ServoMotor m1 = new ServoMotor
                {
                    Snelheid = 30,
                    Encoder = Encoder.Incremental
                };
            m1.Aan();
           // Console.WriteLine(m1.Direction);
            m1.Uit();
            m1.Snelheid = -100;
            m1.Aan();
        }
    }
}
