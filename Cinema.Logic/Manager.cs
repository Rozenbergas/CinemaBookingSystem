using Cinema.Logic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Logic
{
    public class Manager
    {
       public Manager()
        {

        }

        public List<MovieInfo> GetAllMovies()
        {
            //throw new NotImplementedException();
            using (var db = new CinemaDB())
            {
                return db.MovieInfo.OrderByDescending(a => a.Title).ToList();
            }
        }
        public List<MovieInfo> GetMoviesByCategories(int categorieid)
        {
           using(var db = new CinemaDB())
            {
                return db.MovieInfo.OrderByDescending(a => a.CategorieId).Take(categorieid).ToList();
            }
        }
    }
}
