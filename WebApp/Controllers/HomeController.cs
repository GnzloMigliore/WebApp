using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
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
            ViewBag.EstaLogueado = "false";
            try
            {
                var usuario = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("UserSession"));
                if (usuario != null)
                {
                    ViewBag.EstaLogueado = "true";
                }
                ViewBag.Role = usuario.role;
                ViewBag.Usuario = usuario.first_name + " " + usuario.last_name;
            }
            catch
            {

            }
       
            return View();
        }
        public IActionResult Nosotros()
        {
            return View();
        }
        public IActionResult Contacto()
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
