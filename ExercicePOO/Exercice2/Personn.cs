using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice2
{
    internal class Personn
    {
        private string _name;
        private string _firstName;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }

        public void SetAge(int n) { _age = n;  }

        public Personn(string name, string firstName, int age)
        {
            _name = name;
            _firstName = firstName;
            _age = age;
        }
    }
}
