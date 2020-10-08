using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOPS
{
    abstract class Lamp
    {
        private int _lumen = 100;
        
        public int Lumen
        {
            protected get
            {
                return _lumen;
            }
            set
            {
                if (value >= 0 && value < 1000 )
                {
                    _lumen = value;
                }
            }
        }
        public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

        // virtual maakt het Aan gedrag polymorf-ready
        // Overriding is vrijblijvend.
        // Verplicht wordt het met abstract
        public abstract void Aan();
        //{
        //    Console.BackgroundColor = Kleur;
        //    Console.WriteLine("Lamp is aan");
        //}
    }
}
