using CRUD_MVC_max.Data;
using CRUD_MVC_max.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC_max.Controllers
{
    public class LibrosController : Controller
    {

        private readonly ApplicationDbContext _context;

        public LibrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //http Get Index
        public IActionResult Index()
        {
            IEnumerable<Libro> listLibros = _context.Libro;
            return View(listLibros);
        }

        //http Get Create
        public IActionResult Create()
        {
            
            return View();
        }


        //http Post Create}
        [HttpPost]
        public IActionResult Create(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Add(libro);
                _context.SaveChanges();
                


            }
            return RedirectToAction("Index");

        }

        //http Get Editar
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }

            //obtener el libro
            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }


        //http Post EDITar
        [HttpPost]
        public IActionResult Edit(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _context.Libro.Update(libro);
                _context.SaveChanges();
                


            }

            return RedirectToAction("Index");

        }

        //http Get delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }

            //obtener el libro
            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        //post delete
        
        [HttpPost]
        public IActionResult DeleteLibro(int? id)
        {
            var libro = _context.Libro.Find(id);

            if (libro == null)
            {
                return NotFound();
            }

         
            _context.Libro.Remove(libro);
            _context.SaveChanges();
            return RedirectToAction("Index");


         }

            
        

    }
}
