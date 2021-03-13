using Cinema.Logic.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Logic
{
    public class BasketManager
    {
        public List<MovieInfo> Movies { get; set; }

        public int TicketCount { get; set; }
        
        public List<Timetable> Movietime { get; set; }

        
        public BasketManager()
        {
            Movies = new List<MovieInfo>();
            Movietime = new List<Timetable>();
            
        }
        public List<BasketManager> RemoveFromBasket(string title)
        {
            using (var db = new CinemaDB())
            {
                var movie = db.MovieInfo.FirstOrDefault(m => m.Title.ToLower() == title.ToLower());

                if (movie != null)
                {

                    db.Reservation.Remove(new Reservation()
                    {
                        MovieId = movie.Id,

                    });
                    db.SaveChanges();
                }
            }
            return null;
        }

        
        public List<Reservation> AddToBasket(string title)
        {
            
            using (var db = new CinemaDB())
            {
                var movie = db.MovieInfo.FirstOrDefault(m => m.Title.ToLower() == title.ToLower());
                
                if (movie != null)
                {

                    db.Reservation.Add(new Reservation()
                    {
                        MovieId = movie.Id,
                        
                    });
                    db.SaveChanges();
                }
            }
            return null;
        }
        public List<BasketManager> TotalAmount(int count, int price)
        {
            throw new NotImplementedException();
        }

    }



}
