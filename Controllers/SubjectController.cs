using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers
{
  public class SubjectController : Controller
  {
    public IActionResult Index()
    {
      var modelToView = new Subject{
        Name="Programación",
        UniqueId = Guid.NewGuid().ToString()
      };

      return View(modelToView);
    }
    public IActionResult MultiSubjects()
    {
      var listSubjects = new List<Subject>(){
        new Subject{
          Name="Matemáticas",
          UniqueId = Guid.NewGuid().ToString()
        } ,
        new Subject{
          Name="Educación Física",
          UniqueId = Guid.NewGuid().ToString()
        },
        new Subject{
          Name="Castellano",
          UniqueId = Guid.NewGuid().ToString()
        },
        new Subject{
          Name="Ciencias Naturales",
          UniqueId = Guid.NewGuid().ToString()
        }
      };

      ViewBag.dynamicThing = "La Monja";
      ViewBag.Date = DateTime.Now;

      return View("MultiSubjects", listSubjects);
    }
  }
}