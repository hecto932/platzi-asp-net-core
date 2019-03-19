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

      // Upload schoolCourses
      var courses = uploadCourses(school);

      // upload subjects by courses
      var subjects = uploadSubjects(courses);

      // upload students by courses
      var students = uploadStudents(courses);

      modelBuilder.Entity<School>().HasData(school);
      modelBuilder.Entity<Course>().HasData(courses.ToArray());
      modelBuilder.Entity<Subject>().HasData(subjects.ToArray());
      modelBuilder.Entity<Student>().HasData(students.ToArray());
    }

    private List<Student> uploadStudents(List<Course> cursos)
    {
      var listaAlumnos = new List<Student>();

      Random rnd = new Random();
      foreach (var curso in cursos)
      {
        int cantRandom = rnd.Next(5, 20);
        var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
        listaAlumnos.AddRange(tmplist);
      }
      return listaAlumnos;
    }

    private static List<Subject> uploadSubjects(List<Course> courses)
    {
      var completeList = new List<Subject>();
      foreach (var course in courses)
      {
        var tmpList = new List<Subject>(){
            new Subject{Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Matemáticas" },
            new Subject{Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Educación Física" },
            new Subject{Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Castellano" },
            new Subject{Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Ciencias Naturales" },
            new Subject{Id = Guid.NewGuid().ToString(), CourseId = course.Id, Name = "Programación" }
          };
        completeList.AddRange(tmpList);
        // course.Subjects = tmpList;
      }

      return completeList;
    }

    private static List<Course> uploadCourses(School school)
    {
      return new List<Course>(){
        new Course() {
            Id = Guid.NewGuid().ToString(),
            SchoolId = school.Id,
            Name = "101",
            typeWorkDay =  TypeWorkDay.Morning,
            Address = "Av. Siempre viva"
            },
        new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "201", typeWorkDay =  TypeWorkDay.Morning, Address = "Av. Siempre viva" },
        new Course   {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "301", typeWorkDay =  TypeWorkDay.Morning, Address = "Av. Siempre viva" },
        new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "401", typeWorkDay =  TypeWorkDay.Afternoon, Address = "Av. Siempre viva" },
        new Course() {Id = Guid.NewGuid().ToString(), SchoolId = school.Id, Name = "501", typeWorkDay =  TypeWorkDay.Afternoon, Address = "Av. Siempre viva" }
      };
    }

    private List<Student> GenerarAlumnosAlAzar(Course course, int count)
    {
      string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
      string[] lastname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
      string[] secondName = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

      var studentList = from n1 in name1
                        from n2 in secondName
                        from a1 in lastname
                        select new Student
                        {
                          Id = Guid.NewGuid().ToString(),
                          Name = $"{n1} {n2} {a1}",
                          CourseId = course.Id
                        };

      return studentList.OrderBy((student) => student.Id).Take(count).ToList();
    }
  }
}