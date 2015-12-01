namespace BookLibrary.Data
{
    using BookLibrary.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Migrations;

    public class BookLibraryDbContext: DbContext
    {

        public BookLibraryDbContext() : base("BookLibraryConnectionString") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookLibraryDbContext, Configuration>());
        }

        public IDbSet<Book> Books { get; set; }

        public IDbSet<Author> Autors { get; set; }

        public IDbSet<Genre> Genres { get; set; }
    }
}
