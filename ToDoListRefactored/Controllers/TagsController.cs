using ToDoListRefactored.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace ToDoListRefactored.Controllers
{
    public class TagsController : Controller
    {
        private readonly ToDoListContext _db;
        public TagsController(ToDoListContext db)
            {
                _db = db;
            }
        public ActionResult Index()
        {
            return View(_db.Tags.ToList());
        }
    }

}