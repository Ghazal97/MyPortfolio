namespace Core
{
    public interface IUnitOfWork<T> where T : class
    {
       public IGenericRepository<T> genericRepository { get; }
        void Save();
    }
}