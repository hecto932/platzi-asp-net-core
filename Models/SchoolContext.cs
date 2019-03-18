using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace platzi_asp_net_core.Models
{
  public class SchoolContext : DbContext
  {
    public DbSet<School> Schools { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Evaluation> Evaluations { get; set; }

    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      var school = new School();
      school.foundationYear = 2005;
      school.Id = Guid.NewGuid().ToString();
      school.Name = "Platzi";
      school.City = "Bogota";
      school.Country = "Colombia";
      school.Address = "Carrera 1";
      school.TypeSchool = TypeSchool.Secondary;

      modelBuilder.Entity<School>().HasData(school);

      modelBuilder.Entity<Subject>().HasData(
        new Subject
        {
          Name = "Matemáticas",
          Id = Guid.NewGuid().ToString()
        },
        new Subject
        {
          Name = "Educación Física",
          Id = Guid.NewGuid().ToString()
        },
        new Subject
        {
          Name = "Castellano",
          Id = Guid.NewGuid().ToString()
        },
        new Subject
        {
          Name = "Ciencias Naturales",
          Id = Guid.NewGuid().ToString()
        }
      );

      modelBuilder.Entity<Student>().HasData(
        GenerarAlumnosAlAzar().ToArray()
      );
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