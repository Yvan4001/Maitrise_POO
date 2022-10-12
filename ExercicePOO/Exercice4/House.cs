using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice4
{
    internal class House
    {
        public double Surface { get; set; }
        private Door Door = new Door("Red");

        public void Display()
        {
            Console.WriteLine($"Je suis une maison, ma surface est de {Surface} m2");
        }
        
        public House(double surface)
        {
            Surface = surface;
        }

        public Door GetDoor()
        {
            return Door;
        }
    }
}
