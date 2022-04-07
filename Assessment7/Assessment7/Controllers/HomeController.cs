using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment7.Models;

namespace Assessment7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ZooClient zo;
        public HomeController(ILogger<HomeController> logger, ZooClient _zo)
        {
            _logger = logger;
            zo = _zo;
        }

        public async Task<IActionResult> Index()
        {
            return View( await zo.GetAnimalsAsync());
        } 
        
        public async Task<IActionResult> Species([FromForm] string SpeciesName)
        {
            return View( await zo.GetSpecieAsync(SpeciesName));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
