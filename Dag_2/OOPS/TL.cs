using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    class TL : Lamp
    {
        public int StartTijd { get; set; }
        
        // Override 'activeert' het polymorfisme
        public override void Aan()
        {
            
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"Knipperdeknipper gedurende {this.StartTijd} seconden");
            Console.WriteLine($"TL is aan en brandt met {base.Lumen} lm");
        }
    }
}
