using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    class Bokito : IBoikonContract
    {
        public void Produceer()
        {
            Werkt();
        }

        public  void Werkt()
        {
            Console.WriteLine("Bokito mept erop los");
        }
    }
}
