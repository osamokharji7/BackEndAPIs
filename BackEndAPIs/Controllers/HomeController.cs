using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dbBackend.Models;
using System.Text.Json.Serialization;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using dbBackend.Repositories;

namespace dbBackend.Controllers
{
    public class HomeController : Controller
    {
        private UoW unitOfwork = new UoW();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string AddUser([FromBody] User post_data)
        {

            return UoW.userRepository.AddT(post_data);
        }

        [HttpPost]
       
        public string GetStates()
        {
            return UoW.statesRepository.GetTs();
        }

       
        [HttpPost]
        public string GetCities()
        {
            return UoW.citiesRepository.GetTs();
        }
       
    }
}
