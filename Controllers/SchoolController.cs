using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;
using platzi_asp_net_core.Services;

namespace platzi_asp_net_core.Controllers
{
  public class SchoolController : Controller
  {
    private SchoolContext _context;
    public IActionResult Index()
    {
      ViewBag.dynamicThing = "La Monja";
      var school = _context.Schools.FirstOrDefault();
      return Json(school);
    }

    public SchoolController(SchoolContext context) {
      _context = context;
    }
  } 
}