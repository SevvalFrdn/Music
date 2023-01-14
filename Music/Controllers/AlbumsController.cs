using Microsoft.AspNetCore.Mvc;
using Music.Data;
using Music.Models;
using System.Linq;

namespace Music.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AlbumsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var list = _db.Albums.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Album album)
        {
            _db.Add(album);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            var edit = _db.Albums.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Album album)
        {
            _db.Update(album);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.Albums.FirstOrDefault(m => m.AlbumID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DLT(int id)
        {
            var delete = _db.Albums.FirstOrDefault(m => m.AlbumID == id);
            _db.Albums.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
