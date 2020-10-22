using System;
using System.Collections.Generic;
using System.Text;

namespace NPO
{
    delegate void BroadcastMethod(string msg);

    class RadioStation
    {
        //public const int pi = 3;
        // Dit noemen we nu een event
        public event BroadcastMethod Subscribers;

        public void Broadcast()
        {
            Console.WriteLine("De uitzending begint");
            Subscribers("Hallo allemaal");
        }
    }
}
