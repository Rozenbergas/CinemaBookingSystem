﻿using Cinema.Logic.DB;
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

        public List<Timetable> GetTimetable()
        {
            using (var db = new CinemaDB())
            {
                return db.Timetable.ToList();
            }
        }
        public MovieInfo SelectMovieWithTime(string title)
        {
            using (var db = new CinemaDB())
            {
                var movie = db.MovieInfo.FirstOrDefault(m => m.Title.ToLower() == title.ToLower());
                if (movie != null)
                {
                    return movie;
                }
            }
            return null;
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
