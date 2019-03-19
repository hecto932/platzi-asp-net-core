using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class SubjectController : Controller
  {
    [Route("Subject/Index")]
    [Route("Subject/Index/{subjectId}")]
    public IActionResult Index(string subjectId)
    {
      if (!string.IsNullOrWhiteSpace(subjectId))
      {
        var subject = from sub in _context.Subjects
                      where sub.Id == subjectId
                      select sub;
        return View(subject.SingleOrDefault());
      }

      return View("MultiSubjects", _context.Subjects);
    }

    public IActionResult MultiSubjects()
    {
      ViewBag.dynamicThing = "La Monja";
      ViewBag.Date = DateTime.Now;

      return View("MultiSubjects", _context.Subjects);
    }

    private SchoolContext _context;
    public SubjectController(SchoolContext context)
    {
      _context = context;
    }
  }
}