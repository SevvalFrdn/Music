using Microsoft.AspNetCore.Mvc;
using Music.Data;
using Music.Models;
using System.Linq;

namespace Music.Controllers
{
    public class MusicTypesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MusicTypesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var list = _db.MusicTypes.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MusicType type)
        {
            _db.Add(type);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id) 
        {
            var edit = _db.MusicTypes.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int? id, MusicType type)
        {
            _db.Update(type);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.MusicTypes.FirstOrDefault(m => m.MusicTypeID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DLT(int id)
        {
            var delete = _db.MusicTypes.FirstOrDefault(m => m.MusicTypeID == id);
            _db.MusicTypes.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
