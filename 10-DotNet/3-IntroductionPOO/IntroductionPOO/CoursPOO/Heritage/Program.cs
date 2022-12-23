
#region Instanciation d'un objet Fleur et utilisation des méthodes disponibles
using Heritage;
using Heritage.Classes;

Fleur cosmos = new Fleur("Cosmos", "Cosmos Sulphureus");
Console.WriteLine("Mon nom est {0}", cosmos.Nom);
MyFunction.Afficher(cosmos);
Console.WriteLine("");
#endregion

#region Instancication d'un objet Chat et utilisation des méthodes disponibles
Chat felix = new Chat("Felix", "Persan");
Console.WriteLine("Mon nom est {0}", felix.Nom);
felix.Naissance();
felix.Reproduction();
felix.Alimentation();
felix.Expression();
felix.Oxigenation();
felix.Mort();
Console.WriteLine("");
#endregion

#region Instanciation d'un objet Chien et utilisation des méthodes disponibles
Chien medor = new Chien("Medor", "Berger Allemand");
Console.WriteLine("Mon nom est {0}", medor.Nom);
MyFunction.Afficher(medor);
Console.WriteLine("");
#endregion

#region Instanciation d'un objet Poisson et utilisation des méthodes disponibles
Poisson nemo = new Poisson("Némo", "PoissonClown");
Console.WriteLine("Mon nom est {0}", nemo.Nom);
nemo.Naissance();
nemo.Reproduction();
nemo.Alimentation();
nemo.Expression();
nemo.Oxigenation();
nemo.Mort();
Console.WriteLine("");
#endregion

#region Instanciation d'un objet Vache et utilisation des méthodes disponibles
Vache marguerite = new Vache("Marguerite", "Salers");
Console.WriteLine("Mon nom est {0}", marguerite.Nom);
marguerite.Naissance();
marguerite.Reproduction();
marguerite.Alimentation();
marguerite.Expression();
marguerite.Oxigenation();
marguerite.Mort();
Console.WriteLine("");
#endregion


EtreVivant laVache = new Vache("VacheMeuuh", "Normande");
MyFunction.Afficher(laVache);

EtreVivant caniche = new Chien("Snoopy", "caniche");
caniche.Naissance();
caniche.Expression();
Chien Snoopy = (Chien)caniche;
caniche.Mort();
Snoopy.Aboyer();
Console.WriteLine(Snoopy.BattementCoeur);

#region Tableau d'EtreVivant
EtreVivant[] tab = new EtreVivant[6];
EtreVivant etre1 = new Vache("Milka", "Normande");
EtreVivant etre2 = new Chien("Rex", "Caniche");
EtreVivant etre3 = new Chat("Ronron", "Persan");
EtreVivant etre4 = new Poisson("Bubulle", "Poisson Rouge");
EtreVivant etre5 = new Fleur("Belle", "Soucis");
EtreVivant etre6 = new Pangolin("Relou", "D'Asie");

tab[0] = etre1;
tab[1] = etre2;
tab[2] = etre3;
tab[3] = etre4;
tab[4] = etre5;
tab[5] = etre6;
foreach (EtreVivant e in tab)
{
    MyFunction.Afficher(e);
}

#endregion

#region Boxing / Unboxing
// Unboxing de EtreVivant => Chien
Chien medor2 = (Chien)etre2;
medor2.Aboyer();

// Convertion de type
for (int i = 0; i < tab.Length; i++)
{
    // 1er solution Boxing => Unboxing
    // avant la convertion on peut vérifier le type de l'objet
    if (tab[i].GetType() == typeof(Chien))
    {
        Chien c = (Chien)tab[i];
        MyFunction.Afficher(c);
    }

    // 2eme solution => Utiliser le mot clé "as" pour effectuer une conversion
    Pangolin p = tab[i] as Pangolin;
    if (p != null)
        MyFunction.Afficher(p);

    // 3eme solution => En utilisant le mot clé "is" pour effectuer une vérification
    if (tab[i] is Poisson poisson)
        MyFunction.Afficher(poisson);
}

#endregion

//#region Verification pour Marguerite
//if (marguerite.BattementCoeur)
//    marguerite.Naissance();
//else
//    marguerite.Mort();
//#endregion

//#region Passer un objet en paramètre de méthodes
//Afficher(marguerite);
//Afficher(medor);
//#endregion



Console.WriteLine("Stop!");
Console.Read();
