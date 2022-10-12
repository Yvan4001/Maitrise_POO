using ExercicePOO.Exercice1;
using ExercicePOO.Exercice3;
using ExercicePOO.Exercice4;

namespace ExercicePOO.Exercice2
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Exercice 1 ***");
            Circle circle = new Circle(6.25);
            Console.WriteLine("Area: " + circle.GetArea());
            Console.WriteLine("Perimeter: " + circle.GetPerimeter());

            Console.WriteLine();
            Console.WriteLine("*** Exercice 2 ***");
            Console.WriteLine("Hello");
            Student student = new Student("Dupont", "Jean", 0);
            student.SetAge(15);
            student.GoToClasse();
            Console.WriteLine("Hello");
            student.DisplayAge();

            Console.WriteLine("Hello");
            Teacher teacher = new Teacher("Durand", "Paul", 0);
            teacher.SetAge(40);
            teacher.Explain();

            Console.WriteLine();
            Console.WriteLine("*** Exercice 3 ***");
            Complex complex = new Complex(4, 8);
            Complex complex2 = new Complex(4, 6);
            Console.WriteLine("Le nombre complexe est: " + complex.ToString());
            Console.WriteLine("Le nombre complexe est: " + complex2.ToString());
            Console.WriteLine("L'ordre de grandeur est: " + complex2.GetMagnitude());
            complex.Sum(complex2.Real, complex2.Imaginary);
            Console.WriteLine("Apres l'addition: " + complex.ToString());

            Console.WriteLine();
            Console.WriteLine("*** Exercice 4 ***");
            Appartment appartment = new Appartment(200);
            Exercice4.Personn personn = new Exercice4.Personn("Dupont", appartment);
            personn.Display();
        }
    }
}
