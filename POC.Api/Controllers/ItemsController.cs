using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using POC.Models;

namespace POC.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
       

        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            var user = "Venkat";

            Root root = new Root();
            if (user == "Venkat")
            {

                using (StreamReader r = new StreamReader(@"C:\MyComputer\Poc\Venkat\POC\POC.Api\data.json"))
                {
                    string json = r.ReadToEnd();
                    root = JsonConvert.DeserializeObject<Root>(json);
                }
            }
            return root.Items.Item;
        }
    }
}
