using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    class Robotje : IBoikonContract
    {
        public void Produceer()
        {
            Werkt();
        }

        public void Werkt()
        {
            Console.WriteLine("De robot bliept een  product in elkaar");
        }
    }
}
