using Cinema.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Controllers
{
    public class CinemaController : Controller
    {
        private CinemaManager manager = new CinemaManager();
        public IActionResult Movies()
        {
            var mov = manager.GetAllMovies();
            return View(mov);
        }

        
        
    }
}
