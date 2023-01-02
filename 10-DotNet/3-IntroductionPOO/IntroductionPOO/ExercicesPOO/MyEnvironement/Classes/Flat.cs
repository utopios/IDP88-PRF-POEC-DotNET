using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class Flat : Location
    {
        private int id;
        public Flat()
        {

        }

        public Flat(string name, FlatAddress address, List<Person> owners)
        {
            Name = name;
            LocationAddress = address;
            Owners = owners;
            Rooms = new();
        }

        public Flat(string name, FlatAddress address, List<Person> owners, List<Room> rooms)
        {
            Name = name;
            LocationAddress = address;
            Owners = owners;
            Rooms = rooms;
        }

        public int IdFlat { get => id; set => id = value; }

        public override string ToString()
        {
            string chaine = $"Nom Emplacement : {Name} - Type: Appartement" +
                $"\nNombre d'occupants: {Owners.Count}" +
                $"\nNombre de pièces: {Rooms.Count}\nListe des occupants :";
            foreach (Person p in Owners)
            {
                chaine += p.ToString();
            }
            chaine += $"\n{LocationAddress.ToString()}\nListe des pièces :";
            foreach (Room r in Rooms)
            {
                if (Rooms.Count > 0)
                    chaine += r.ToString();
                else
                    chaine += "Aucune pièce, Veuillez ajouter une pièce à la liste";
            }
            return chaine;
        }
    }
}
