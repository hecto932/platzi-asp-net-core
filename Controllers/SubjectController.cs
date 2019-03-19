using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class SubjectController : Controller
  {
    public IActionResult Index()
    {
      return View(_context.Subjects.FirstOrDefault());
    }
    public IActionResult MultiSubjects()
    {
      ViewBag.dynamicThing = "La Monja";
      ViewBag.Date = DateTime.Now;

      return View("MultiSubjects", _context.Subjects);
    }

    private SchoolContext _context;
    public SubjectController(SchoolContext context) {
      _context = context;
    }
  }
}