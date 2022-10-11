using System;
using Maitrice_POO.Encapsulation;
using Maitrice_POO.Interface;
using Maitrice_POO.Polymorphisme;

namespace Maitrice_POO;
class Programm
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        //Console.WriteLine("Hello, World!");

        //int[] tab, tab2;
        //Manager.Instance.DefTableau(out tab, out tab2);

        //Console.WriteLine("Tableau 1");
        //foreach (var item in tab)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine("Tableau 2: ");

        //foreach (var item in tab2)
        //{
        //    Console.WriteLine(item);
        //}

        //int[,] tab3 = new int[2, 3];
        //tab3[0, 0] = 1;
        //tab3[0, 1] = 2;
        //tab3[0, 2] = 3;
        //tab3[1, 0] = 4;
        //tab3[1, 1] = 5;
        //tab3[1, 2] = 6;

        //Console.WriteLine("Tableau 3: ");

        //foreach (var item in tab3)
        //{
        //    Console.WriteLine(item);
        //}

        //int[,,] tab4 = {
        //    { { 1, 2, 3 }, { 4, 5, 6 } },
        //    { { 7, 8, 9 }, { 10, 11, 12 } }
        //};

        //Console.WriteLine("Tableau 4: ");
        //foreach (var item in tab4)
        //{
        //    Console.WriteLine(item);
        //}
        //string[] transports = { "Moto", "Voiture", "Avion", "Bateau", "Train", "Bus", "Velo", "Avion" };
        //Manager.Instance.RechercheTransport(transports);

        //Console.WriteLine();
        //var a = 10;
        //var b = 30;

        //Manager.Instance.FonctionSpe(ref a, ref b);

        //Console.WriteLine();
        Console.WriteLine("*** Encapsulation ***");
        try
        {
            Rectangle rect = new Rectangle(40, 10);
            Console.WriteLine("* Rectangle *");
            Console.WriteLine($"Longueur: {rect.Longeur}");
            Console.WriteLine($"Largeur: {rect.Largeur}");
            Console.WriteLine($"Aire: {rect.Aire}");
            Console.WriteLine($"Perimetre: {rect.Perimetre}");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine();
        Console.WriteLine("*** Interface ***");
        IClient clientD = new DbClientService();
        IClient clientW = new WebClientService();
        
        var client = new Client
        {
            Id = 1,
            Nom = "Dupont",
            Prenom = "Jean",
            Adresse = new Adresse
            {
                Numero = 1,
                Voie = "Rue de la Paix",
                Ville = "Paris",
                CodePostal = "75000",
                Pays = "France"
            }
        };

        Console.WriteLine(client.ToString());

        var client2 = new Client
        {
            Id = 2,
            Nom = "Simon",
            Prenom = "Yvan",
            Adresse = new Adresse
            {
                Numero = 48,
                Voie = "Boulevard JF Kenndy",
                Ville = "Oullins",
                CodePostal = "69600",
                Pays = "France"
            }
        };

        Console.WriteLine(client2.ToString());

        Console.WriteLine();
        Console.WriteLine("*** Polymorphisme ***");
        Table table = null;
        PolyTest.Acheter(table);
    }
}
