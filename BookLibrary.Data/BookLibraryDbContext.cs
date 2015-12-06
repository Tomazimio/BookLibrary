namespace BookLibrary.Data
{
    using Model;
    using Migrations;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;
    using Repository;

    public class BookLibraryDbContext : IdentityDbContext<User>, IBookLibraryDbContext
    {
        public BookLibraryDbContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookLibraryDbContext, Configuration>());
        }

        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Author> Authors { get; set; }

        public virtual IDbSet<Genre> Genres { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
