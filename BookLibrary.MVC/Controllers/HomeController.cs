namespace BookLibrary.MVC.Controllers
{
    using Model;
    using Data;
    using System.Web.Mvc;
    using System.Linq;
    using Data.Repository;

    public class HomeController : Controller
    {

        private IBookLibraryDbContext db;

        public HomeController()
        {
            db = new BookLibraryDbContext();
        }

        public ActionResult Index()
        {

            //IQueryable<Book> books = this.db.Books;

            var books = this.db.Books.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}