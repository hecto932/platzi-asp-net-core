using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class CourseController : Controller
  {
    private SchoolContext _context;
    public CourseController(SchoolContext context)
    {
      _context = context;
    }

    public IActionResult Index(string id)
    {

      ViewBag.Date = DateTime.Now;

      if (!string.IsNullOrWhiteSpace(id))
      {
        var course = from c in _context.Courses
                     where c.Id == id
                     select c;
        return View(course.SingleOrDefault());
      }

      return View("MultiCourses", _context.Courses);
    }

    public IActionResult Create()
    {
      ViewBag.Date = DateTime.Now;

      return View();
    }

    [HttpPost]
    public IActionResult Create(Course course)
    {
      ViewBag.Date = DateTime.Now;

      if (ModelState.IsValid)
      {
        var school = _context.Schools.FirstOrDefault();

        course.SchoolId = school.Id;

        _context.Courses.Add(course);
        _context.SaveChanges();
        ViewBag.extraMessage = "Course created successfully";
        return View("Index", course);

      }
      return View(course);
    }
  }
}