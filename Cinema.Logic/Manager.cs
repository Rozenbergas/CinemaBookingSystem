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
        
        //public List<Cinema> GetAvailableMovies()
        //{
        //    using (var db = new CinemaDB())
        //    {
        //        return db.Cinema.OrderBy(b => b.Title).ToList();
        //    }
        //}
        public List<Categories> GetMoviesByCategories(int categorieid)
        {
            throw new NotImplementedException();
        }
    }
}
