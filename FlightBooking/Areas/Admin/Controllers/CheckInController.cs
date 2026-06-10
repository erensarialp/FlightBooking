using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    public class CheckInController : Controller
    {
        [Area("Admin")]
        public IActionResult Index(string id)
        {
            ViewBag.flightNumber = TempData["flightnumber"];
            return View();
        }
    }
}
