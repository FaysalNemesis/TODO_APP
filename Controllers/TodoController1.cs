using Microsoft.AspNetCore.Mvc;

namespace TodoMVCApp.Controllers
{
    public class TodoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
