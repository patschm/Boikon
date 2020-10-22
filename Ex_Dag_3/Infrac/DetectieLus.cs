using IEEE;
using System;
using System.Collections.Generic;

namespace Infrac
{
    public class DetectieLus
    {
        private List<IDetectable> devices = new List<IDetectable>();
        private TriggerAction actions;
        // Or
        public event TriggerAction Detect;

        public void Connect(TriggerAction action)
        {
            actions += action;
        }
        public void Connect(IDetectable app)
        {
            devices.Add(app);
        }

        public void Trigger()
        {
            Console.WriteLine("De detectielus ziet wat");
            actions();

            Detect();
            //foreach(IDetectable device in devices)
            //{
            //    device.Activate();
            //}
        }
    }
}
