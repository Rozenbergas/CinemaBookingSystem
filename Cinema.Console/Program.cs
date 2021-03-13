using Cinema.Logic;
using System;

namespace Cinema.Console
{
    class Program
    {
        static CinemaManager Manager = new CinemaManager();
        static BasketManager Basket = new BasketManager();
        static void Main(string[] args)
        {
            
            //list of all movies
            System.Console.WriteLine("All movies:");
            Manager.GetAllMovies().ForEach(m => { System.Console.WriteLine(m.Title); });

            //to choose title and add to basket
            while (true)
            {
                System.Console.WriteLine("Please input movie title or 'stop'.");
                string userinput = System.Console.ReadLine();
                if (userinput == "stop" || userinput == "STOP")
                {
                    break;
                }
                else
                {
                   var timing =  Manager.GetTimetable();
                    System.Console.WriteLine("Choose time");
                    var usertime = System.Console.ReadLine();
                    if (timing == null )
                    {
                        System.Console.WriteLine("Time not available, please choose different time.");
                    }
                    else
                    {
                        Basket.AddToBasket(userinput);
                    }
                }
            }
           
            
        }

    }
}
