using TP03.Models;

namespace TP03.Datas
{
    public class BooksRepository : BaseRepository, IRepository<Book>
    {
        public BooksRepository(MockDatabase database) : base(database)
        {
        }

        public Book Add(Book entity)
        {
            _database.Books.Add(entity);

            return entity;
        }

        public bool Delete(int id)
        {
            return _database.Books.Remove(GetById(id));
        }

        public List<Book> GetAll()
        {
            return _database.Books.ToList();
        }

        public Book GetById(int id)
        {
            return _database.Books.FirstOrDefault(x => x.Id == id);
        }

        public Book Update(int id, Book entity)
        {
            Book bookToEdit = GetById(id);

            if (bookToEdit != null)
            {
                bookToEdit.Title = entity.Title;
                bookToEdit.Description = entity.Description;
                bookToEdit.ISBN = entity.ISBN;
                bookToEdit.PictureURL = entity.PictureURL;
                bookToEdit.Price = entity.Price;
                bookToEdit.BookCategory = entity.BookCategory;
                bookToEdit.ReleaseDate = entity.ReleaseDate;
                bookToEdit.Author = entity.Author;
            }

            return bookToEdit;
        }
    }
}
