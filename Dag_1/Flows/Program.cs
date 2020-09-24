using System;

namespace Flows
{
    class Program
    {
        static void Main(string[] args)
        {
            // Forward jumps
            int nr = 0;
            bool isGelijk = nr == 0;
            if (isGelijk)
            {
                // if true
            }
            else if (nr < 10) // optional
            {

            }


            switch (nr)
            {
                case -1:
                case 0:
                    Console.WriteLine("Nul");
                    break;
                case 1:
                    Console.WriteLine("Een");
                    break;

                default:
                    Console.WriteLine("Anders");
                    break;

            }

            // Back jumps (loops)
            // Gebruik for als je weet _hoe vaak_ je iets moet herhalen
            for (int nrx = 0; nrx < 10 ; nrx++)
            {
                if (nrx == 5) continue;
                
                Console.WriteLine("opnieuw " + nrx);             
            }

            // While gebruik je als je niet precies weet hoe vaak je iets moet herhalen
            // Misschien wel geen herhaling
            // 0 of meer keer uitgevoerd
            while(nr < 10)
            {
                Console.WriteLine(nr++);
            }

            // Do gebruik je als je niet precies weet hoe vaak je iets moet herhalen
            // Wordt tenminste 1 keer uitgevoerd
            // Met name gebruikt voor user invoer
            do
            {
                Console.WriteLine(nr++);
            }
            while (nr < 15);

        }
    }
}
