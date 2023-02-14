namespace TP03.Datas
{
    public abstract class BaseRepository
    {
        protected readonly MockDatabase _database;

        public BaseRepository(MockDatabase database)
        {
            _database = database;
        }
    }
}
