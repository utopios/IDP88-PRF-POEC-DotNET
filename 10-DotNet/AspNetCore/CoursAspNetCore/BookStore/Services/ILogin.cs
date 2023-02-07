namespace BookStore.Services
{
    public interface ILogin
    {
        public bool Login(string email, string password);
        public void Logout();
        public string GetEmail();
        public bool IsLoggedIn();
        public bool IsAdmin();

    }
}
