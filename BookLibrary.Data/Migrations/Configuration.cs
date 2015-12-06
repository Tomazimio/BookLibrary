namespace BookLibrary.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookLibrary.Data.BookLibraryDbContext>
    {
        private UserManager<User> userManager;

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookLibraryDbContext context)
        {
            this.userManager = new UserManager<User>(new UserStore<User>(context));
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("Admin"));
            context.Roles.AddOrUpdate(x => x.Name, new IdentityRole("User"));
            context.SaveChanges();

            var defaultUser = new User { Email = "default_user@abv.com", UserName = "demo" };
            this.userManager.Create(defaultUser, "diMANA123");
            this.userManager.AddToRole(defaultUser.Id, "User");

            var adminUser = new User
            {
                   Email = "dimanakehayova@gmail.com",
                   UserName = "Administrator"
            };
            this.userManager.Create(adminUser, "diMANA123");
            this.userManager.AddToRole(adminUser.Id, "Admin");

            Genre genreAction = new Genre { GenreName = "Action" };
            Genre genreDrama = new Genre { GenreName = "Drama" };
            Genre genreAdventure = new Genre { GenreName = "Adventure" };

            context.Genres.AddOrUpdate(genreAction,genreDrama,genreAdventure);

            Author teryPratched = new Author { FirstName = "Author", LastName = "Demo" };
            Author ivanPetrov = new Author { FirstName = "Ivan", LastName = "Petrov" };

            context.Books.AddOrUpdate(
                new Book { Title = "Demo Book One", ReleaseDate = DateTime.Now, Autors = { teryPratched, ivanPetrov }, Description = "some description for test" , Genre = genreAction } ,
                new Book { Title = "Test Boom Two", ReleaseDate = DateTime.Now, Autors = { teryPratched }, Description = "some description for test for" , Genre = genreAdventure}
            );

            context.SaveChanges();
        }
    }
}
