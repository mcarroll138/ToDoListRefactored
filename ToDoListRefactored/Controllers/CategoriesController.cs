using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ToDoListRefactored.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoListRefactored.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly ToDoListContext _db;

        public CategoriesController(ToDoListContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Category> model = _db.Categories.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Category thisCategory = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
            return View(thisCategory);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            _db.Categories.Update(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }


}



