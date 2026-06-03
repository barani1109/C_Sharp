using Question2.Models;
using Question2.Repository;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Question2.Controllers
{
    public class MoviesController : Controller
    {
        IRepository<Movie> repo;

        public MoviesController()
        {
            repo = new MovieRepository();
        }

        // GET: Movies
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        // CREATE
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                repo.Insert(movie);
                repo.Save();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // EDIT
        public ActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            repo.Update(movie);
            repo.Save();
            return RedirectToAction("Index");
        }

        // DELETE
        public ActionResult Delete(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            repo.Delete(id);
            repo.Save();
            return RedirectToAction("Index");
        }

        // Movies by Year
        public ActionResult MoviesByYear(int year)
        {
            var movies = repo.GetAll()
                             .Where(m => m.DateOfRelease.Year == year);

            return View(movies);
        }

        // Movies by Director
        public ActionResult MoviesByDirector(string directorName)
        {
            var movies = repo.GetAll()
                             .Where(m => m.DirectorName == directorName);

            return View(movies);
        }
    }
}