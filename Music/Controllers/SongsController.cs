using Microsoft.AspNetCore.Mvc;
using Music.Data;
using Music.Models;
using System.Linq;

namespace Music.Controllers
{
    public class SongsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SongsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var list = _db.Songs.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Song song)
        {
            _db.Add(song);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            var edit = _db.Songs.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Song song)
        {
            _db.Update(song);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.Songs.FirstOrDefault(m => m.SongID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DLT(int id)
        {
            var delete = _db.Songs.FirstOrDefault(m => m.SongID == id);
            _db.Songs.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
