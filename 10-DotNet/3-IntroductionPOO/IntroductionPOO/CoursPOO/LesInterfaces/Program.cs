
#region IAdresse
using LesInterfaces;
using LesInterfaces.Classes;

personne p = new personne(new Adresse2()) { Nom = "Di Persio", Prenom = "Anthony" };
Console.WriteLine(p);
#endregion

#region Ivolant
List<IVolant> volants = new List<IVolant>();
volants.Add(new Oiseau());
volants.Add(new Avion());
volants.Add(new Drone());
foreach (IVolant v in volants)
{
    v.Voler();
}
IVolant avion = new Avion();
IVolant drone = new Drone();
TransportColis t = new TransportColis(drone);
t.Transporter();
t.livrer();
Console.Read();
#endregion
