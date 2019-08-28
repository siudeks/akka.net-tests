using Microsoft.AspNetCore.Mvc;
using Web.Pages;

namespace Web.Controllers
{
    public class MyIndexController : Controller
    {
        private static int value;

        public MyIndexController()
        {

        }
        public IActionResult Index()
        {
            return View(new IndexModel { Value = value++.ToString() } );
        }
    }
}