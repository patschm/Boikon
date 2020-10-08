using System;
using System.Collections.Generic;
using System.Text;

namespace MotorRevisie
{
    class ServoMotor : Motor
    {
        public int TargetSpeed { get; set; }

        protected void Accelerate()
        {
            Console.WriteLine("Accelerate..");
            CurrentSpeed = TargetSpeed;
        }
        protected void Decelerate()
        {
            CurrentSpeed = 0;
        }
        public override void Start()
        {
            Console.WriteLine("Servomotor starts");
            Accelerate();
        }
        public override void Stop()
        {
            Console.WriteLine("Servomotor stops");
            Decelerate();
        }
    }
}
