namespace DinoAPI.Models
{
    public class Dinosaur
    {
        public static int Count;
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Specy { get; set; }
        public int Age { get; set; }

        public DinoColor Color { get; set; }

        public Dinosaur() 
        {
            Id = ++Count;
        }

        public enum DinoColor 
        {
            Red,
            Green,
            Blue,
            Yellow,
        }
    }
}
