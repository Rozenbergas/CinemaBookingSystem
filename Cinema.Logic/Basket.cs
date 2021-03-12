using Cinema.Logic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Logic
{
    public class Basket
    {
        public List<MovieInfo> Movies { get; set; }

        public int TicketCount { get; set; }
        
        public List<Timetable> Movietime { get; set; }

        
        public Basket()
        {
            Movies = new List<MovieInfo>();
            Movietime = new List<Timetable>();
            
        }
        public List<Basket> RemoveFromBasket(string title)
        {
            using (var db = new CinemaDB())
            {
                var movie = db.MovieInfo.FirstOrDefault(m => m.Title.ToLower() == title.ToLower());

                if (movie != null)
                {

                    db.Rservation.Remove(new Rservation()
                    {
                        MovieId = movie.Id,

                    });
                    db.SaveChanges();
                }
            }
            return null;
        }

        
        public List<Rservation> AddToBasket(string title)
        {
            
            using (var db = new CinemaDB())
            {
                var movie = db.MovieInfo.FirstOrDefault(m => m.Title.ToLower() == title.ToLower());
                
                if (movie != null)
                {

                    db.Rservation.Add(new Rservation()
                    {
                        MovieId = movie.Id,
                        
                    });
                    db.SaveChanges();
                }
            }
            return null;
        }
        public List<Basket> TotalAmount(int count, int price)
        {
            throw new NotImplementedException();
        }

    }



}
