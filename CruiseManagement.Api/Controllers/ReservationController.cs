using Microsoft.AspNetCore.Mvc;

namespace CruiseManagement.Api.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
