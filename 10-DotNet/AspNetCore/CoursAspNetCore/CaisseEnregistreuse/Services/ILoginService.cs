namespace CaisseEnregistreuse.Services
{
    public interface ILoginService
    {
        public bool Login(string email, string password);
        public bool IsLogged();

        public string GetEmail();
    }
}
