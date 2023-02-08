using System.Security.Claims;

namespace TP03.Models
{
    public class WebAppUser
    {
        public static int Count;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Claim> Claims { get; set; }

        public WebAppUser()
        {
            Id = ++Count;
            Claims = new List<Claim>();
        }
    }
}
