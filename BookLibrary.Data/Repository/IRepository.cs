namespace BookLibrary.Data.Repository
{
    using System.Linq;

    public interface IRepository<T> where T: class
    {
        IQueryable<T> All();

        void Add(T entity);

        void Delete(T entity);

        void Detach(T entity);

        void Update(T entity);
    }
}
