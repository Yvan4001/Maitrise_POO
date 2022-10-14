#region Using
using MaitrisePOO_Intermediaire.DesignsPatterns.Adapter;
using MaitrisePOO_Intermediaire.EntiteVsObjectValeur;
using MaitrisePOO_Intermediaire.DesignsPatterns.Decorator;
using MaitrisePOO_Intermediaire.DesignsPatterns.Proxy;
using MaitrisePOO_Intermediaire.DesignsPatterns.ChaineOfResponsability;
using MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple1;
using MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple2;
using ContactObs = MaitrisePOO_Intermediaire.DesignsPatterns.Observer.Exemple2.Contact; //Permet de résoudre le conflit de nom entre les classes Contact de l'exemple 2 et Adapter
using MaitrisePOO_Intermediaire.DesignsPatterns.Command;

#endregion

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

IJsonAdapter adapter = new JsonAdapter(new ContactRepository());

//string json = adapter.RecupContactsJson("contacts.xml");

//Console.WriteLine(json);
Console.WriteLine("Ficher XML non créé");
#endregion

#region Design Patern - Bridge

Console.WriteLine();
Console.WriteLine("*** Design Patern - Bridge ***");
Console.WriteLine();
//Voir le dossier Bridge pour le code de l'exemple
Console.WriteLine("Voir le dossier Bridge pour le code de l'exemple");
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

#region Desing Patern - Observer

Console.WriteLine();
Console.WriteLine("*** Design Patern - Observer ***");
Console.WriteLine();

ObserverMethod();

static void ObserverMethod()
{
    Console.WriteLine("Exemple 1");
    var produit = new Produit()
    {
        Id = 1,
        Description = "RTX 4090",
        Prix = 1300
    };

    produit.AttachObserver(new Client("Dupont", "drenfa.meedman@gmail.com") { Id = 1 });
    produit.AttachObserver(new Client("Martin", "drenfa.meedman@gmail.com") { Id = 2 });
    produit.Prix = 150; //Cette modification déclenche l'envoi d'un mail aux clients

    Console.WriteLine("\nExemple 2");
    var article = new Article()
    {
        Description = "Chaise",
        Prix = 20
    };

    var disC1 = article.Subscribe(new ContactObs() { Nom = "John" });
    var disC2 = article.Subscribe(new ContactObs() { Nom = "Jane" });

    article.Prix = 30;

    disC1.Dispose(); //C1 se desinscrit

    article.Prix = 20;
}

#endregion

#region Desing Patern - Command

Console.WriteLine();
Console.WriteLine("*** Design Patern - Command ***");
Console.WriteLine();

var chef = new ChefCuisine();
var serveur = new Serveur();

ICommander commandeDej = new CommandeDej(chef, "Burger");
ICommander commandeDin = new CommandeDin(chef, "Pizza");

serveur.TakeCommande(commandeDej);
serveur.TakeCommande(commandeDin);

#endregion

#region SOLID - Demeter

Console.WriteLine();
Console.WriteLine("*** SOLID - Demeter ***");
Console.WriteLine();
Console.WriteLine("Voir le dossier SOLID/Demeter pour le code de l'exemple");

#endregion

#region SOLID - Separation

Console.WriteLine();
Console.WriteLine("*** SOLID - Separation ***");
Console.WriteLine();
Console.WriteLine("Voir le dossier SOLID/S pour le code de l'exemple");

#endregion

#region SOLID - Open Close

Console.WriteLine();
Console.WriteLine("*** SOLID - Open Close ***");
Console.WriteLine();
Console.WriteLine("Voir le dossier SOLID/O pour le code de l'exemple");

#endregion

#region SOLID - Liskov Substitution

Console.WriteLine();
Console.WriteLine("*** SOLID - Liskov Substitution ***");
Console.WriteLine();
Console.WriteLine("Permet de découper un scripts maitre en plusieurs scripts plus petit (Héritage)");
Console.WriteLine("Voir le dossier SOLID/L pour le code de l'exemple");

#endregion

#region SOLID - Interface Segregation

Console.WriteLine();
Console.WriteLine("*** SOLID - Interface Segregation ***");
Console.WriteLine();
Console.WriteLine("Permet de découper des interfaces en plusieurs interfaces plus petites");

#endregion

#region SOLID - Dependency Inversion

Console.WriteLine();
Console.WriteLine("*** SOLID - Depency Inversion ***");
Console.WriteLine();
Console.WriteLine("Voir le dossier SOLID/D pour le code de l'exemple");

#endregion