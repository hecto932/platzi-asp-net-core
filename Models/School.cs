using System.Collections.Generic;

namespace platzi_asp_net_core.Models
{
  public class School : ObjSchoolBase
  {
    public int foundationYear { get; set; }

    public string Country { get; set; }
    public string City { get; set; }

    public string Address { get; set; }

    public TypeSchool TypeSchool { get; set; }

    public List<Course> Courses { get; set; } = new List<Course>();

    // Igualacion por Tuplas, clasico en lenguajes funcionales
    public School(string name, int year) => (Name, foundationYear) = (name, year);


    public School(
      string name,
      int year,
      TypeSchool typeSchool,
      string country = "",
      string city = ""
    ) : base()
    {
      (Name, foundationYear) = (name, year);
      Country = country;
      City = City;
    }

    public School()
    {

    }

    public override string ToString()
    {
      return $"Name: \"{Name}\", TypeSchool: {TypeSchool} {System.Environment.NewLine}Country: {Country}, City: {City}";
    }
  }
}