using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class productController : Controller
    {
        public IActionResult Index()
        {
            product pr = new product();
            pr.id = 1;
            pr.name = "Test";
            pr.price = 100;
            pr.number = 123;
            return View(pr);
        }

    }
}
