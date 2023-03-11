using Assessment7a.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Assessment7a.DAL;
using System.Net;

namespace Assessment7a.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        Animal repo = new Animal();
        [HttpGet()]
        public List<Animal> GetAnimals()
        {
            return Animal.GetAll();
        }


        public IActionResult Index()
        {
            string apiUri = "https://gc-zoo.surge.sh/";
           // var apiTask = apiUri.GetJsonAsync<Animal>();

                return View("Animal");


            
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
        public IActionResult Species( string SpeciesName)
        {
            SpeciesName = "/api/species/{name}.json";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}