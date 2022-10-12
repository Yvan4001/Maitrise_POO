using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice4
{
    internal class Appartment : House
    {
        public Appartment(double surface) : base(surface)
        {
            if(surface > 50)
            {
                base.Surface = 50;
            }         
        }
    }
}
