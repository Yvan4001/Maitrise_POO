using System;

namespace Maitrice_POO;
class Programm
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        int[] tab, tab2;
        Manager.Instance.DefTableau(out tab, out tab2);

        Console.WriteLine("Tableau 1");
        foreach (var item in tab)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Tableau 2: ");

        foreach (var item in tab2)
        {
            Console.WriteLine(item);
        }

        int[,] tab3 = new int[2, 3];
        tab3[0, 0] = 1;
        tab3[0, 1] = 2;
        tab3[0, 2] = 3;
        tab3[1, 0] = 4;
        tab3[1, 1] = 5;
        tab3[1, 2] = 6;

        Console.WriteLine("Tableau 3: ");

        foreach (var item in tab3)
        {
            Console.WriteLine(item);
        }

        int[,,] tab4 = {
            { { 1, 2, 3 }, { 4, 5, 6 } },
            { { 7, 8, 9 }, { 10, 11, 12 } }
        };

        Console.WriteLine("Tableau 4: ");
        foreach (var item in tab4)
        {
            Console.WriteLine(item);
        }
        string[] transports = { "Moto", "Voiture", "Avion", "Bateau", "Train", "Bus", "Velo", "Avion" };
        Manager.Instance.RechercheTransport(transports);

        Console.WriteLine();
        var a = 10;
        var b = 30;

        Manager.Instance.FonctionSpe(ref a, ref b);
    }
}
