using DinoAPI.Models;

namespace DinoAPI.Datas
{
    public class FakeDB
    {
        private List<Dinosaur> _dinosaurs { get; set; }

        public FakeDB() 
        {
            _dinosaurs = new List<Dinosaur>()
            {
                new Dinosaur{ Age=20, Name="Denver", Color=Dinosaur.DinoColor.Green, Species="Corythosaurus"},
                new Dinosaur{ Age=16, Name="Petit pieds", Color=Dinosaur.DinoColor.Yellow, Species="Apatosaurus"}
            };
        }

        public List<Dinosaur> GetAll()
        {
            return _dinosaurs;
        }

        public List<Dinosaur> GetAll(string startSpecies)
        {
            return _dinosaurs.FindAll(d => d.Species!.StartsWith(startSpecies));
        }

        public Dinosaur? GetById(int id)
        {
            return _dinosaurs.FirstOrDefault(d => d.Id == id);
        }

        public Dinosaur? GetByName(string name)
        {
            return _dinosaurs.FirstOrDefault(d => d.Name == name);
        }

        public bool Add(Dinosaur dinosaur)
        {
            _dinosaurs.Add(dinosaur);
            return true;
        }

        public bool Edit(int id, Dinosaur dinosaur)
        {
            var dinoFromDB = _dinosaurs.FirstOrDefault(d => d.Id == id);

            if (dinoFromDB == null) return false;

            dinoFromDB.Name = dinosaur.Name;
            dinoFromDB.Species = dinosaur.Species;
            dinoFromDB.Age = dinosaur.Age;
            dinoFromDB.Color = dinosaur.Color;

            return true;
        }

        public bool Delete(int id)
        {
            _dinosaurs.RemoveAll(d => d.Id == id);
            return true;
        }
    }
}
