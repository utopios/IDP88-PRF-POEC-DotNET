using TP03.Models;

namespace TP03.Datas
{
    public class WebAppUsersRepository : BaseRepository, IRepository<WebAppUser>
    {
        public WebAppUsersRepository(MockDatabase database) : base(database)
        {
        }

        public WebAppUser Add(WebAppUser entity)
        {
            _database.WebAppUsers.Add(entity);

            return entity;
        }

        public bool Delete(int id)
        {
            return _database.WebAppUsers.Remove(GetById(id));
        }

        public List<WebAppUser> GetAll()
        {
            return _database.WebAppUsers.ToList();
        }

        public WebAppUser GetById(int id)
        {
            return _database.WebAppUsers.FirstOrDefault(x => x.Id == id);
        }

        public WebAppUser Update(int id, WebAppUser entity)
        {
            WebAppUser found = GetById(id);

            if (found != null)
            {
                found.Email = entity.Email;
                found.UserName = entity.UserName;
                found.Password = entity.Password;
                found.FirstName = entity.FirstName;
                found.LastName = entity.LastName;
                found.Claims = entity.Claims;
            }

            return found;
        }
    }
}
