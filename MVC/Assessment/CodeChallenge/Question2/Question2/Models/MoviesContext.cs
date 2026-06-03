using Question2.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Question2.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext() : base("MoviesDB")
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}