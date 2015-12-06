namespace BookLibrary.Data.Repository
{
    using System.Data.Entity;
    using Model;
    using System.Data.Entity.Infrastructure;

    public interface IBookLibraryDbContext
    {
        IDbSet<Book> Books { get; set; }

        IDbSet<Author> Authors { get; set; }

        IDbSet<Genre> Genres { get; set; }

        IDbSet<User> Users { get; set; }

        void SaveChanges();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
