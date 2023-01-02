using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyEnvironement.Classes
{
    internal class House : Location
    {
        private int id;
        public House()
        {

        }

        public House(string name, HouseAddress address, List<Person> owners)
        {
            Name = name;
            LocationAddress = address;
            Owners = owners;
            Rooms = new();
        }

        public House(string name, HouseAddress address, List<Person> owners, List<Room> rooms)
        {
            Name = name;
            LocationAddress = address;
            Owners = owners;
            Rooms = rooms;
        }

        public int IdHouse { get => id; set => id = value; }

        public override string ToString()
        {
            string chaine = $"Nom Emplacement : {Name} - Type: Maison" +
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
