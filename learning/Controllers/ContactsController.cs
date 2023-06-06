using Microsoft.AspNetCore.Mvc;

namespace learning.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
