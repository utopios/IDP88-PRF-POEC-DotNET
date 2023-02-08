using TP03.Models;

namespace TP03.Datas
{
    public class AuthorsRepository : BaseRepository, IRepository<Author>
    {
        public AuthorsRepository(MockDatabase database) : base(database)
        {
        }

        public Author Add(Author entity)
        {
            _database.Authors.Add(entity);

            return entity;
        }

        public bool Delete(int id)
        {
            return _database.Authors.Remove(GetById(id));
        }

        public List<Author> GetAll()
        {
            return _database.Authors.ToList();
        }

        public Author GetById(int id)
        {
            return _database.Authors.FirstOrDefault(x => x.Id == id);
        }

        public Author Update(int id, Author entity)
        {
            Author authorToEdit = GetById(id);

            if (authorToEdit != null)
            {
                authorToEdit.Firstname = entity.Firstname;
                authorToEdit.Lastname = entity.Lastname;
                authorToEdit.BirthDate = entity.BirthDate;
                authorToEdit.PictureURL = entity.PictureURL;
                authorToEdit.Books = entity.Books;
            }

            return authorToEdit;
        }
    }
}
