using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MotorRevisie
{
    abstract class Motor
    {
        public int Vermogen { get; set; }
        public int CurrentSpeed { get; set; }
        public Orientation DraaiRichting { get; set; }

        public abstract void Start();
        public abstract void Stop();
    }
}
