using joelWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace joelWeb.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;

        public HomeController(Context temp) //constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult movie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult movie(Application response) 
        {
            _context.Applications.Add(response); //adds the record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    
    }
}
