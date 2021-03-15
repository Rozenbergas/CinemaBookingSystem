using Cinema.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Controllers
{
    public class BasketController : Controller
    {
        private BasketManager basket = new BasketManager();

        public IActionResult Index()
        {
            var reservedmovies = basket.Movies;
            return View(reservedmovies);
        }
    }
}
