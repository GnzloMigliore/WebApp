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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar([Bind("id,name,description,gender,price,stock,image")]Producto producto)
        {
             List<Talle> talles = context.Talles.ToList();
            if (ModelState.IsValid)
            {
           var new_producto =  context.Productos.Add(producto);

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
        // GET: Estudiantes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Estudiantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,description,gender,price,stock, image")] Producto producto)
        {
            if (id != producto.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    context.Update(producto);
                    await context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }
        private bool ProductoExists(int id)
        {
            return context.Productos.Any(e => e.id == id);
        }

    }
}

