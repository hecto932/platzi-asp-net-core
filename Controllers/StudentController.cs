using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class StudentController : Controller
  {
    public IActionResult Index()
    {
      return View(_context.Students);
    }
    public IActionResult MultiStudents()
    {
      ViewBag.dynamicThing = "La Monja";
      ViewBag.Date = DateTime.Now;

      return View("MultiStudents", _context.Students);
    }
    
    private SchoolContext _context;
    public StudentController(SchoolContext context) {
      _context = context;
    }
  }
}