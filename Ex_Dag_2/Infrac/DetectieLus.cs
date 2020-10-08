using IEEE;
using System;
using System.Collections.Generic;

namespace Infrac
{
    public class DetectieLus
    {
        private List<IDetectable> devices = new List<IDetectable>();

        public void Connect(IDetectable app)
        {
            devices.Add(app);
        }

        public void Trigger()
        {
            Console.WriteLine("De detectielus ziet wat");
            foreach(IDetectable device in devices)
            {
                device.Activate();
            }
        }
    }
}
