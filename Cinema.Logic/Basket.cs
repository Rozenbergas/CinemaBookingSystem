using Cinema.Logic.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Logic
{
    public class Basket
    {
        public List<MovieInfo> Movies { get; set; }

        public int TicketCount { get; set; }

        
        public Basket()
        {
            Movies = new List<MovieInfo>();
        }
        public List<Basket> RemoveFromBasket(int count, string title)
        {
            throw new NotImplementedException();
        }

        public List<Basket> TotalAmount(int count, int price)
        {
            throw new NotImplementedException();
        }

        //public Basket AddToBasket(int count, string title)
        //{
        //    count = int.Parse(Console.ReadLine());
        //    using (var db = new CinemaDB())
        //    {
        //        var movie = db.MovieInfo.FirstOrDefault(m => m.Title.ToLower() == title.ToLower());
        //        if (movie != null)
        //        {
        //            for (int i = 0; i < count; i++)
        //            {

        //            }

        //        }
        //    }
        //    return null;
        //}

    }



}
