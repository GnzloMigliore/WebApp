using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace WebApp.Controllers

{
    public class UserController : Controller
    {
        TiendaContext context = new();
        public IActionResult Index(string v)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar([Bind("id,first_name,last_name,email,password,gender,phone,role")] User usuario)
        {
            if (ModelState.IsValid)
            {
                context.Usuarios.Add(usuario);

                await context.SaveChangesAsync();


            }


            return RedirectToAction(nameof(Login));
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Login(string email, string password)
        {
            try
            {
                User user = (from d in context.Usuarios
                             where d.email == email.Trim() && d.password == password.Trim()
                             select d).FirstOrDefault();
                if (user == null)
                {
                    ViewBag.Error = "Usuario o contraseña invalida";
                    return View();
                }
                HttpContext.Session.SetString("UserSession", JsonConvert.SerializeObject(user));
                ViewBag.Usuario = user.last_name;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return RedirectToAction("Login");

            } 
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}