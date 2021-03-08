using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cinema.Logic.DB
{
    public partial class Cinema
    {
        public int Id { get; set; }
        public int Categorie { get; set; }
        public string Title { get; set; }
        public decimal PricePerPerson { get; set; }
        public TimeSpan? Time1 { get; set; }
        public TimeSpan? Time2 { get; set; }
        public TimeSpan? Time3 { get; set; }
    }
}
