using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice2
{
    internal class Teacher : Personn
    {
        public Teacher(string name, string firstName, int age) : base(name, firstName, age)
        {
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }
}
