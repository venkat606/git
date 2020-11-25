using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using POC.Models;
using POC.UI.Models;

namespace POC.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string url = "http://localhost:54627/items";
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;

            var content2 = response.Content.ReadAsStringAsync().Result;
            List<Item> result = new List<Item>();
            result = JsonConvert.DeserializeObject<List<Item>>(content2);


            return View(result);
          
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
