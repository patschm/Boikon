using System;
using System.Collections.Generic;
using System.Text;

namespace DeFabriek
{
    class Lamp
    {
        // Eigenschappen leg je vast in variabelen die in deze context fields worden genoemd.
        private int lumen = 120;
        //private ConsoleColor kleur = ConsoleColor.Green;

        // C++, Java, Delphi
        // En dotnetter doet dat anders
        public int GetLumen()
        {
            return lumen;
        }
        public void SetLumen(int nw)
        {
            if (nw >= 0 && nw < 1000)
            {
                lumen = nw;
            }
        }

        // Properties
        // Geven gecontroleerde toegang tot jouw fields (Encapsulation)
        public int Lumen
        {
            get
            {
                return lumen;
            }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    lumen = value;
                }
            }
        }
        // Auto generating property
        // Genereert zijn eigen private field
        public ConsoleColor Kleur { get; set; } = ConsoleColor.Blue;

        // Gedrag leg je vast methods.
        public void Aan()
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"De lamp brandt met {Lumen} lumen");
        }
        public void Uit()
        {
            Console.ResetColor();
            Console.WriteLine("De lamp is uit");
        }

        // Constructors
        // Om initiele waarden mee te geven
        // Om fields van een initiele waarde te voorzien
        public Lamp(int lumen, ConsoleColor kleur)
        {
            this.Lumen = lumen;
            this.Kleur = kleur;
        }
        public Lamp()
        {

        }
    }
}
