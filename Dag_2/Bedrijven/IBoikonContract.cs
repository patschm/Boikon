using System;
using System.Collections.Generic;
using System.Text;

namespace Bedrijven
{
    // Interfaces zorgen voor een ontkoppeling van twee of meer objecten
    // Je erft niet van een interface (er valt niks te erven)
    // Stel je de vraag: Kan het object iets  (Can-do relatie)
    interface IBoikonContract
    {
        void Produceer();
    }
}
