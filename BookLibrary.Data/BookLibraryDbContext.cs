using BookLibrary.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Data
{
    public class BookLibraryDbContext : IdentityDbContext<User>
    {
        public BookLibraryDbContext()
            : base("DefaultConnection")
        {
        }

        //public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Author> Authors { get; set; }

        public virtual IDbSet<Genre> Genres { get; set; }

    }
}
