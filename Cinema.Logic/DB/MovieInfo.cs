using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cinema.Logic.DB
{
    
    public partial class MovieInfo
    {
        public int Id { get; set; }
        public int CategorieId { get; set; }
        public string Title { get; set; }
        public decimal PricePerPerson { get; set; }
        public MovieInfo()
        {

        }
    }
}
