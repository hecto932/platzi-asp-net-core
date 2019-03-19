using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class StudentController : Controller
  {
    // [Route("Student/Index")]
    // [Route("Student/Index/{studentId}")]
    public IActionResult Index(string id)
    {
      ViewBag.dynamicThing = "La Monja";
      ViewBag.Date = DateTime.Now;

      if (!string.IsNullOrWhiteSpace(id)) {
        var student = from s in _context.Students
                      where s.Id == id
                      select s;
        return View(student.SingleOrDefault());
      }

      return View("MultiStudents", _context.Students);
    }
    
    private SchoolContext _context;
    public StudentController(SchoolContext context) {
      _context = context;
    }
  }
}