using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AdminProductsController : Controller
    {
        TiendaContext context = new();

        public async Task<IActionResult> Index()
        {
            return View(await context.Productos.ToListAsync());
        }
        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }
      
        // GET: Estudiantes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await context.Productos
                .FirstOrDefaultAsync(m => m.id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Estudiantes/Create
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Agregar([Bind("id,name,description,gender,price,stock")]Producto producto)
        {
            if (ModelState.IsValid)
            {
                context.Productos.Add(producto);
                await context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await context.Productos.FindAsync(id);
            context.Productos.Remove(producto);
            await context.SaveChangesAsync();

            return View(await context.Productos.ToListAsync());
        }
      

    }
}

