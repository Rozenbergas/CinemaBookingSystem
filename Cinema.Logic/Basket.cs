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

    }  
    

    
}
