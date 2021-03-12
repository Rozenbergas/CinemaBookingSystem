using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Cinema.Logic.DB
{
    public partial class Rservation
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int TimeId { get; set; }
        public int TicketCount { get; set; }
    }
}
