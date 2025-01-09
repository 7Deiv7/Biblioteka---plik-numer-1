using Biblioteka.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Controllers
{
    public class BookController : Controller
    {

         private readonly BookDbContext _context;
         public BookController(BookDbContext context)
         {
            _context = context;
         }

        // GET: BookController
        public ActionResult Index()
        {
            var books = _context.Books.Include(b => b.Author).ToList(); 
            return View(books);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {

            var book = _context.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound(); 
            }

            return View(book); 
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            
            
            var kategorie = _context.Kategorie.ToList();
            if (!kategorie.Any())
            {
                throw new Exception("Brak kategorii w bazie danych");
            }
            ViewBag.KategoriaId = new SelectList(kategorie, "Id", "Name");
            return View(new Book());
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Title,Isbn,KategoriaId")] Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Books.Add(book);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {

                }
            }

            var kategorie = _context.Kategorie.ToList();
            ViewBag.KategoriaId = new SelectList(kategorie, "Id", "Name");
            return View(book);



        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            var book = _context.Books.Find(id); 

            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book)
        {
            

            _context.Books.Update(book); 
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var book = _context.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book); 
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmation(int id)
        {

            var book = _context.Books.Find(id);

            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book); 
            _context.SaveChanges();      
            return RedirectToAction(nameof(Index));
        }
    }
}
