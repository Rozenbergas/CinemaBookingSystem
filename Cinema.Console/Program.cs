using Cinema.Logic;
using System;

namespace Cinema.Console
{
    class Program
    {
        static CinemaManager Manager = new CinemaManager();
        static void Main(string[] args)
        {
            
            //list of all movies
            System.Console.WriteLine("All movies:");
            Manager.GetAllMovies().ForEach(m => { System.Console.WriteLine(m.Title); });
            
           
            
        }

    }
}
