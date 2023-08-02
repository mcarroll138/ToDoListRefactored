using Microsoft.AspNetCore.Mvc;
using ToDoListRefactored.Models;

namespace ToDoListRefactored.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
}
