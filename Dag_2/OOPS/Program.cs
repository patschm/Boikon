using System;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Lamp l1 =   new TL();
            l1.Aan();

            Lamp t1 = new TL(); // Generaliseren
            ((TL)t1).StartTijd = 2;
            //Console.WriteLine(t1.Lumen);
            t1.Aan();
           // ((TL)t1).Aan();
        }
    }
}
