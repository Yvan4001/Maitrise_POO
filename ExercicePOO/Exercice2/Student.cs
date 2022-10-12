using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice2
{
    internal class Student : Personn
    {
        public Student(string name, string firstName, int age) : base(name, firstName, age)
        {
        }

        public void GoToClasse()
        {
            Console.WriteLine("I'm going to class.");
        }

        public void DisplayAge()
        {
            Console.WriteLine("I'm " + base.Age + " years old.");
        }
    }
}
