using Question2.Models;

using Question2.Repository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Question2.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        MoviesContext db = new MoviesContext();

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetById(object id)
        {
            return db.Movies.Find(id);
        }

        public void Insert(Movie obj)
        {
            db.Movies.Add(obj);
        }

        public void Update(Movie obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            Movie m = db.Movies.Find(id);
            db.Movies.Remove(m);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}