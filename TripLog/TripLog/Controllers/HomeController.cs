using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TripLog.Models;

namespace TripLog.Controllers
{
    public class HomeController : Controller
    {
        private TripContext context { get; set; }

        public HomeController(TripContext ctx) => context = ctx;

        public ViewResult Index() 
        {
            var trips = context.Trips.OrderBy(t => t.StartDate).ToList();
            return View(trips);
        }

    }
}
