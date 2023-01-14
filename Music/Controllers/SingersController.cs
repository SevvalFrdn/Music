using Microsoft.AspNetCore.Mvc;
using Music.Data;
using Music.Models;
using System.Linq;

namespace Music.Controllers
{
    public class SingersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SingersController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            var list = _db.Singers.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Singer singer)
        {
            _db.Add(singer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            var edit = _db.Singers.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Singer singer)
        {
            _db.Update(singer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.Singers.FirstOrDefault(m => m.SingerID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DLT(int id)
        {
            var delete = _db.Singers.FirstOrDefault(m => m.SingerID == id);
            _db.Singers.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
