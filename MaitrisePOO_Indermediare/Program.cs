using MaitrisePOO_Intermediaire.DesignsPatterns.Adapter;
using MaitrisePOO_Intermediaire.EntiteVsObjectValeur;
using MaitrisePOO_Intermediaire.DesignsPatterns.Decorator;
using MaitrisePOO_Intermediaire.DesignsPatterns.Proxy;
using MaitrisePOO_Intermediaire.DesignsPatterns.ChaineOfResponsability;


#region Entites Object Valeur

Console.WriteLine("*** Entites Object Valeur ***");
Console.WriteLine();

Entreprise e1 = new Entreprise(1, "Dawan", new GeoLocation(3.3527, 48.8543));
var e2 = new Entreprise(2, "Jehann", new GeoLocation(3.37, 48.8543));

int compareParNom = e1.CompareTo(e2);
int compareParLocalisation = e1.CompareToLocalisation(e2);
Console.WriteLine(compareParNom + " | " + compareParLocalisation);

List<Entreprise> entreprises = new List<Entreprise> { e1, e2 };
entreprises.Sort(); //Tri par nom
entreprises.ForEach(e => Console.WriteLine(e.Nom));

#endregion

#region Design Patern - Adapter

Console.WriteLine();
Console.WriteLine("*** Design Patern - Adapter ***");
Console.WriteLine();

//IJsonAdapter adapter = new JsonAdapter(new ContactRepository());

//string json = adapter.RecupContactsJson("contacts.xml");

//Console.WriteLine(json);
#endregion

#region Design Patern - Bridge

Console.WriteLine();
Console.WriteLine("*** Design Patern - Bridge ***");
Console.WriteLine();
//Voir le dossier Bridge pour le code de l'exemple

#endregion

#region Design Patern - Decorator

Console.WriteLine();
Console.WriteLine("*** Design Patern - Decorator ***");
Console.WriteLine();

IVoiture voiture = new VoitureBasic();

voiture = new SportDecorator(voiture);

voiture = new LuxeDecorator(voiture);
voiture.Assembler();
Console.WriteLine();

//Autre solution
Console.WriteLine("\tAutre solution");
Console.WriteLine();

IVoiture voitureSportLuxe = new SportDecorator(new LuxeDecorator(new VoitureBasic()));
voitureSportLuxe.Assembler();

#endregion

#region Design Patern - Proxy

Console.WriteLine();
Console.WriteLine("*** Design Patern - Proxy ***");
Console.WriteLine();

IMessage message = new MessageUtilisateur("Bonjour");
Console.WriteLine(message.RecupContent());

Console.WriteLine("... proxy ...");
message = new MessageProxy(message);
Console.WriteLine(message.RecupContent());

#endregion

#region Design Patern - Chaine of Responsability

ChaineOfResponsabilityMethod();

static void ChaineOfResponsabilityMethod()
{
    Console.WriteLine();
    Console.WriteLine("*** Design Patern - Chaine of Responsability ***");
    Console.WriteLine();

    Console.WriteLine("-- Plainte 1 --");
    MembreEquipe formateur = new Formateur("Jesus",
        new DirPedagogie("John Doe",
        new Directeur("Dupont", null)));

    Plainte plainteFor = new Plainte(1, Types.Formateur, "la plainte du formateur", Etats.Ouvert);
    formateur.HandlePlainte(plainteFor);

    Console.WriteLine();
    Console.WriteLine("-- Plainte 2 --");
    MembreEquipe dirPedago = new DirPedagogie("John Doe",
        new Directeur("Dupont", null));

    Plainte plainteDirPeda = new Plainte(1, Types.DirPeda, "la plainte du Directeur Peda", Etats.Ouvert);
    dirPedago.HandlePlainte(plainteDirPeda);

    Console.WriteLine();
    Console.WriteLine("-- Plainte 3 --");
    MembreEquipe dir = new Directeur("Dupont", null);

    Plainte plainteDirP = new Plainte(1, Types.Directeur, "la plainte du formateur", Etats.Ouvert);
    dirPedago.HandlePlainte(plainteDirPeda);

    Console.WriteLine();

    Console.WriteLine("-- Plainte 4 --");
    MembreEquipe formateur2 = new Formateur("Jesus",
        new DirPedagogie("John Doe",
        new Directeur("Dupont", null)));

    Plainte plainteFor2 = new Plainte(1, Types.Directeur, "la plainte du formateur", Etats.Ouvert);
    formateur.HandlePlainte(plainteFor2);

    Console.WriteLine();
}

#endregion