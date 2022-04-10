using ParisBakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ParisBakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly ParisBakeryContext _db;
    public HomeController(ParisBakeryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      ViewBag.Treats = _db.Treats.ToList();
      ViewBag.Flavors = _db.Flavors.ToList();
      return View();
    }
  }
}