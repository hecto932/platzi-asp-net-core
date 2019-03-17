using System;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class SchoolController : Controller
  {
    public IActionResult Index()
    {
      var school = new School();

      school.foundationYear = 2005;
      school.UniqueId = Guid.NewGuid().ToString();
      school.Name = "Platzi";
      school.City = "Bogota";
      school.Country = "Colombia";
      school.Address = "Carrera 1";
      school.TypeSchool = TypeSchool.Secondary;

      ViewBag.dynamicThing = "La Monja";

      return View(school);
    }
  }
}