using System.ComponentModel.DataAnnotations;

namespace DinoAPI.Models
{
    public class Dinosaur
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; }
        public int Age { get; set; }
        public DinoColor Color { get; set; }
        public enum DinoColor 
        {
            Red,
            Green,
            Blue,
            Yellow,
        }
    }
}
