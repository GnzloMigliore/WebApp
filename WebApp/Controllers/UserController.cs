using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        TiendaContext context = new();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar([Bind("id,first_name,last_name,email,password,gender,phone")] User usuario)
        {
            if (ModelState.IsValid)
            {
                context.Usuarios.Add(usuario);

                await context.SaveChangesAsync();


            }


            return RedirectToAction(nameof(Index));
        }
    }
}
