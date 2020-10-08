using System;

namespace MotorRevisie
{
    class Program
    {
        static void Main(string[] args)
        {
            ServoMotor m1 = new ServoMotor { TargetSpeed = 120 };
            BrandstofMotor m2 = new BrandstofMotor();

           // TestMotor(m1);
           // TestMotor(m2);

            Motor[] motoren = new Motor[5];
            motoren[0] = m1;
            motoren[1] = m2;
            motoren[2] = new ServoMotor { TargetSpeed = 200 };
            motoren[3] = new BrandstofMotor();
            motoren[4] = new BrandstofMotor();


            foreach(Motor m in motoren)
            {
                // Niet te vaak gebruiken
                // Hiervan krijg ik een vieze smaak. Lijkt op een hack
                if (m is BrandstofMotor)
                {
                    BrandstofMotor x = m as BrandstofMotor;
                    x.Gas(45);
                }
                m.Start();
                Console.WriteLine($"Speed is {m.CurrentSpeed}");
            }

        }

        private static void TestMotor(Motor motor)
        {
            motor.Start();
            Console.WriteLine($"Snelheid is {motor.CurrentSpeed}");
            motor.Stop();
        }
    }
}
