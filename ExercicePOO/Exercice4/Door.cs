using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice4
{
    internal class Door
    {
        public string Color { get; set; } = "Red";

        public Door(string color)
        {
            Color = color;
        }
        
        public void Display()
        {
            Console.WriteLine($"Je suis une porte, ma couleur est {Color}");
        }
    }
}
