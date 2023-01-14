using Microsoft.AspNetCore.Mvc;
using Music.Data;
using Music.Models;
using System.Linq;

namespace Music.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CompaniesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var list = _db.Companys.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {
            _db.Add(company);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            var edit = _db.Companys.Find(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int? id, Company company)
        {
            _db.Update(company);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = _db.Companys.FirstOrDefault(m => m.CompanyID == id);
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DLT(int id)
        {
            var delete = _db.Companys.FirstOrDefault(m => m.CompanyID == id);
            _db.Companys.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
