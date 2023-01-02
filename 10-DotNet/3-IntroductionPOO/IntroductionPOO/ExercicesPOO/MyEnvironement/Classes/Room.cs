using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnvironement.Classes
{
    internal class Room
    {
        private int id;
        private string roomName;
        private List<Furniture> furnitureList;
        private List<Equipment> equipmentList;
        public Room()
        {
            FurnitureList = new();
            EquipmentList = new();
        }
        public Room(string roomName, List<Furniture> furnitureList, List<Equipment> equipmentList) 
        {            
            RoomName = roomName;
            FurnitureList = furnitureList;
            EquipmentList = equipmentList;
        }

        public Room(int id, string roomName, List<Furniture> furnitureList, List<Equipment> equipmentList)
        {
            Id = id;
            RoomName = roomName;
            FurnitureList = furnitureList;
            EquipmentList = equipmentList;
        }

        public int Id { get => id; set => id = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public List<Furniture> FurnitureList { get => furnitureList; set => furnitureList = value; }
        public List<Equipment> EquipmentList { get => equipmentList; set => equipmentList = value; }


    }
}
