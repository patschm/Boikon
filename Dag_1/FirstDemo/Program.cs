using System;


namespace FirstDemo
{


    class Program
    {
        static void Main(string[] args)
        {
            // Variable. Declareer je op functie, procedure of method nivo
            // ****************************
            // TypeName varname
            // *****************************
            int age = 10;
            string name = "Patrick";
            bool isOk = true;

            Console.WriteLine(age);

            // Scope van een variable
            // Wordt bepaald door de { }
            {
                int last = 2002;
                Console.WriteLine(last);
            }

            // Expression
            //   operant  operator   operant
            // Unary  (1 operant)
            // Binary  (2 operants)
            // Ternary (3 operants)

            //++age;
            Console.WriteLine(++age);

            age = 20;
            age += 2;

            name = age > 20 ? "OK" : "Niet OK";

            int? leeftijd = null;

            int echteLeeftijd = leeftijd.HasValue ? leeftijd.Value : 42;
            echteLeeftijd = leeftijd ?? 42;

        }
    }
}
