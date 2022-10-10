using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maitrice_POO
{
    public class Manager
    {
        private static readonly Manager instance = new Manager();

        Manager() { }
        
        public static Manager Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Permet de rechercher un transport dans un tableau de transport
        /// </summary>
        /// <param name="transports"></param>
        public void RechercheTransport(string[] transports)
        {
            Console.Write("Entrer le transport à rechercher: ");
            var recherche = Console.ReadLine();
            var trouve = false;

            for (int i = 0; i < transports.Length; i++)
            {
                if (transports[i].Equals(recherche))
                {
                    trouve = true;
                }
                else
                    trouve = false;

                if (trouve)
                {
                    Console.WriteLine("Le transport recherché est: " + transports[i] + " et il est à la position: " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Le transport recherché n'existe pas");
                    break;
                }
            }

        }

        public void Permetutation(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
        
        public void DefTableau(out int[] tab, out int[] tab2)
        {
            tab = new int[3];
            tab[0] = 1;
            tab[1] = 2;
            tab[2] = 3;

            tab2 = new int[5];
            tab2[0] = 1;
            tab2[1] = 2;
            tab[2] = 3;
            tab2[3] = 4;
            tab2[4] = 5;
        }

        public double Calculer(double a, double b, out double somme, out double moyenne)
        {
            somme = a + b;
            moyenne = (a + b) / 2;
            return a % b;
        }

        public double Multiplication(in int a, in int b)
        {
            return a * b;
        }

        public void FonctionSpe(ref int a, ref int b)
        {
            PermutationPrivate(ref a, ref b);

            CaluculerPrivate(a, b);

            var multi = Manager.Instance.Multiplication(a, b);
            Console.WriteLine("Multiplication :" + multi);
        }

        private void CaluculerPrivate(int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine($"Fonction calculer de {a} et {b}");
            var resultat = Calculer(a, b, out double somme, out double moyenne);
            Console.WriteLine("Somme: " + somme);
            Console.WriteLine("Moyenne: " + moyenne);
            Console.WriteLine("Modulo: " + resultat);
        }

        private void PermutationPrivate(ref int a, ref int b)
        {
            Console.WriteLine($"Permutation de {a} et {b}");
            Console.WriteLine("Avant permutation: " + a + " et " + b);
            Permetutation(ref a, ref b);
            Console.WriteLine("Après permutation: " + a + " et " + b);
            Console.WriteLine(a);
        }
    }
}
