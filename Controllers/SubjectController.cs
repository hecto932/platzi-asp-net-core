using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class SubjectController : Controller
  {
    public IActionResult Index()
    {
      var subject = new Subject{
        UniqueId = Guid.NewGuid().ToString(),
        Name="Programming"
      };

      ViewBag.dynamicThing = "La Monja";
      ViewBag.Date = DateTime.Now;

      return View(subject);
    }
  }
}