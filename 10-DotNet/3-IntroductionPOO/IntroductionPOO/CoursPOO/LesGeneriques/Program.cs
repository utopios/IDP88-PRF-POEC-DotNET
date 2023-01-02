
#region Les éléments Genreiques
using LesGeneriques.Classes;

Console.WriteLine("***** Les Elements Generiques *****");
Console.WriteLine("Avec des types Int : ");
Operation<int> obj1= new Operation<int>();
Console.WriteLine(obj1.EstEquivalent(2,3));
Console.WriteLine("Avec des types Double : ");
Operation<double> obj2 = new Operation<double>();
Console.WriteLine(obj2.EstEquivalent(3.35, 3.35));
Console.WriteLine("Avec des types String : ");
Operation<string> obj3 = new Operation<string>();
Console.WriteLine(obj3.EstEquivalent("Bonjour", "Bonjour"));

#endregion

#region LesPiles<> LIFO (Last In First Out)

Console.WriteLine("***** Les Piles<T> *****");
Console.WriteLine("Pile des types Int : ");
Pile<int> pileEntier = new Pile<int>(3);
pileEntier.Empiler(1);
pileEntier.Empiler(25);
pileEntier.Empiler(35);
pileEntier.Empiler(45);

Console.WriteLine($"L'element en place 1 de la pile est : {pileEntier.Get(0)}");
Console.WriteLine($"L'element en place 2 de la pile est : {pileEntier.Get(1)}");
Console.WriteLine($"L'element en place 3 de la pile est : {pileEntier.Get(2)}");

pileEntier.Depiler();

Console.WriteLine($"L'element en place 1 de la pile est : {pileEntier.Get(0)}");
Console.WriteLine($"L'element en place 2 de la pile est : {pileEntier.Get(1)}");
Console.WriteLine($"L'element en place 3 de la pile est : {pileEntier.Get(2)}");

pileEntier.Depiler();

Console.WriteLine($"L'element en place 1 de la pile est : {pileEntier.Get(0)}");
Console.WriteLine($"L'element en place 2 de la pile est : {pileEntier.Get(1)}");
Console.WriteLine($"L'element en place 3 de la pile est : {pileEntier.Get(2)}");

Console.WriteLine("***** Les Piles<T> *****");
Console.WriteLine("Pile des types Voiture : ");
Pile<Voiture> pileVoiture = new Pile<Voiture>(3);
pileVoiture.Empiler(new("Ceed","verte", 35, 700));
pileVoiture.Empiler(new("Kuga","grise", 55, 850));
pileVoiture.Empiler(new("Clio","Blanche", 45, 850));
pileVoiture.Empiler(new("3008","Rouge", 65, 850));


Console.WriteLine($"L'element en place 1 de la pile est : {pileVoiture.Get(0)}");
Console.WriteLine($"L'element en place 2 de la pile est : {pileVoiture.Get(1)}");
Console.WriteLine($"L'element en place 3 de la pile est : {pileVoiture.Get(2)}");

pileVoiture.Depiler();

Console.WriteLine($"L'element en place 1 de la pile est : {pileVoiture.Get(0)}");
Console.WriteLine($"L'element en place 2 de la pile est : {pileVoiture.Get(1)}");
Console.WriteLine($"L'element en place 3 de la pile est : {pileVoiture.Get(2)}");

pileVoiture.Depiler();

Console.WriteLine($"L'element en place 1 de la pile est : {pileVoiture.Get(0)}");
Console.WriteLine($"L'element en place 2 de la pile est : {pileVoiture.Get(1)}");
Console.WriteLine($"L'element en place 3 de la pile est : {pileVoiture.Get(2)}");


#endregion

#region Le Queue<> FIFO
Console.WriteLine("*** Le Queue<> ***");
Console.WriteLine("Avec des types int :");
Queue<int> file = new Queue<int>();
file.Enqueue(1);
file.Enqueue(2);
file.Enqueue(3);
file.Enqueue(4);
int valeur = file.Dequeue();
AfficherChiffre(valeur);
valeur = file.Dequeue();
AfficherChiffre(valeur);
valeur = file.Dequeue();
AfficherChiffre(valeur);
valeur = file.Dequeue();
AfficherChiffre(valeur);

Console.WriteLine("Avec des types string :");
Queue<string> chaines = new Queue<string>();
chaines.Enqueue("chaine 1");
chaines.Enqueue("chaine 2");
chaines.Enqueue("chaine 3");
chaines.Enqueue("chaine 4");

string chaine = chaines.Dequeue();
AfficherChaine(chaine);
chaine = chaines.Dequeue();
AfficherChaine(chaine);
chaine = chaines.Dequeue();
AfficherChaine(chaine);
chaine = chaines.Dequeue();
AfficherChaine(chaine + Environment.NewLine);


#region Methodes
static void AfficherChiffre(int i)
{
    Console.WriteLine("Le chiffre extrait est : {0}", i);
}
static void AfficherChaine(string s)
{
    Console.WriteLine("La chaine extraite est : {0}", s);
}
#endregion
#endregion

#region Les Dictionnaires<>
Console.WriteLine("*** Les Dictionnaires ***");
Dictionary<string, Personne> annuaire = new Dictionary<string, Personne>();
annuaire.Add("06 01 02 03 04", new Personne { Prenom = "Nicolas" });
annuaire.Add("06 06 06 06 06", new Personne { Prenom = "Jeremie" });
Personne p = annuaire["06 06 06 06 06"];
Console.WriteLine(p.Prenom);
p = annuaire["06 01 02 03 04"];
Console.WriteLine(p.Prenom + Environment.NewLine);
#endregion

#region Les List<>
Console.WriteLine("*** Les List<T> ***");
Console.WriteLine("Avec des types int :");
List<int> listEntiers = new List<int>();
listEntiers.Add(10);
listEntiers.Add(20);
listEntiers.Add(30);
Console.WriteLine($"La liste contient {listEntiers.Count} éléments");
foreach (int nombre in listEntiers)
    Console.WriteLine(nombre);
Console.WriteLine("Je retire la valeur 10");
listEntiers.Remove(10);
Console.WriteLine($"La liste contient {listEntiers.Count} éléments");
foreach (int nombre in listEntiers)
    Console.WriteLine(nombre);

Console.WriteLine("Avec des types Voiture :");
List<Voiture> listVoiture = new List<Voiture>();
listVoiture.Add(new("Ceed", "verte", 35, 700));
listVoiture.Add(new("Kuga", "grise", 55, 850));

Console.WriteLine($"La liste de voiture contient {listVoiture.Count} voitures");
foreach (Voiture v in listVoiture)
    Console.WriteLine(v);

#endregion

Console.WriteLine("Appuyez sur ENTER pour fermer la console");
Console.Read();
