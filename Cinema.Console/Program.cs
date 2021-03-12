using Cinema.Logic;
using System;

namespace Cinema.Console
{
    class Program
    {
        static Manager Manager = new Manager();
        static void Main(string[] args)
        {
            System.Console.WriteLine("All movies:");
            Manager.GetAllMovies().ForEach(m => { System.Console.WriteLine(m.Title); });


            
        }

    }
}
