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
      var modelToView = new Student
      {
        Name = "Pepe Perez",
        Id = Guid.NewGuid().ToString()
      };

      return View(modelToView);
    }
    public IActionResult MultiStudents()
    {
      var studentList = GenerarAlumnosAlAzar();

      ViewBag.dynamicThing = "La Monja";
      ViewBag.Date = DateTime.Now;

      return View("MultiStudents", studentList);
    }

    private List<Student> GenerarAlumnosAlAzar()
    {
      string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
      string[] lastname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
      string[] secondName = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

      var studentList = from n1 in name1
                         from n2 in secondName
                         from a1 in lastname
                         select new Student { Name = $"{n1} {n2} {a1}" };

      return studentList.OrderBy((student) => student.Id).ToList();
    }
  }
}