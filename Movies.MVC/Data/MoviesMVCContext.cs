using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies.MVC.Models;

namespace Movies.MVC.Data
{
    public class MoviesMVCContext : DbContext
    {
        public MoviesMVCContext (DbContextOptions<MoviesMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Movies.MVC.Models.Movie> Movie { get; set; }
    }
}
