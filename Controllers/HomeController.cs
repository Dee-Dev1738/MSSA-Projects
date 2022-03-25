using Microsoft.AspNetCore.Mvc;
using Assignment_11._4.Services;

namespace Assignment_11._4.Controllers
{
    public class HomeController : Controller
    {
        private IDataRepository _data; // dependency injection
        public HomeController(IDataRepository data)
        {
            // get a object of random
            _data = data;
        }
        public IActionResult Index()
        {
            ViewBag.product = _data.GetAll();
            return View();
        }
    }
}
