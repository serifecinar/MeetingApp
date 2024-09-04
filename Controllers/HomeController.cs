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
            int saat= DateTime.Now.Hour;
            var selamlama = saat > 12 ? "İyi Günler":"Günaydın";
            return View(model: selamlama);
        }
    }
}