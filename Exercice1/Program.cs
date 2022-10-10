namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 10, 0, 20, 15 };
            int a1 = 10;
            int b1 = 20;

            //1. créé une méthode "Somme" qui retourne la somme de 2 entiers
            /*2. créé 2 méthode "Afficher" (surcharge):
             * a. Affiche un texte
             * b. Affiche les éléments de tab1
             * */

            /*
             * 3. Créer moi une surcharge de la méthode "Somme" qui retourne la somme des élements de tab1
             * 4. Créer moi une méthode "Min" qui retourne le minimum de tab1
             * 5. Créer moi une méthode "Moy" qui retourne la moyenne de tab1
             * 6. Créer moi une méthode "Calculer" qui prend en paramétre 1 tableau en entrée (tab1) qui calcule 2 valeurs: la somme et le minmum
             * Ces valeur devront etre passé via des paramètre de sortie
            */

            Console.WriteLine("Tableau: ");
            Afficher(tab1);

            Console.WriteLine();
            Console.Write("Affiche le message passé en paramètre: ");
            Afficher("Hello world");

            Console.WriteLine();
            Console.WriteLine($"Somme de {a1} et {b1}: {Somme(a1, b1)}");

            Calculer(tab1, out int somme, out int min);

            Console.WriteLine("Somme de tab1: " + somme);
            Console.WriteLine("Minium du tableau: " + min);
            Console.WriteLine("Moyenne du tableau: " + Moy(tab1));

        }

        private static int Somme(int a1, int a2)
        {
            return a1 + a2;
        }

        private static int Somme(int[] tab1)
        {
            int somme = 0;
            foreach (var item in tab1)
            {
                somme += item;
            }
            return somme;
        }

        private static int Min(int[] tab1)
        {
            int min = tab1[0];
            
            /*foreach (var item in tab1)
            {
                if (item < min)
                    min = item;
            }
            return min;*/

            var i = 1;
            while (i < tab1.Length)
            {
                if (min > tab1[i++])
                    min = tab1[i - 1];
            }
            return min;
        }

        private static double Moy(int[] tab1)
        {
            return (double)Somme(tab1) / tab1.Length;
        }

        private static void Afficher(string text)
        {
            Console.WriteLine(text);
        }

        private static void Afficher(int[] tab1)
        {
            foreach (var item in tab1)
            {
                Console.WriteLine(item);
            }
        }

        private static void Calculer(int[] tab1, out int somme, out int min)
        {
            somme = Somme(tab1);
            min = Min(tab1);
        }
    }
}   
