using Microsoft.AspNetCore.Mvc;

namespace MeetinApp.Controllers
{
    public class HomeController: Controller
    {
        // localhost
        // localhost/home
        // localhost/home/index        
        public IActionResult Index()
        {
            return View();
        }
    }
}