using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platzi_asp_net_core.Models
{
  public class Course : ObjSchoolBase
  {
    [Required]
    public override string Name { get; set; }
    public TypeWorkDay typeWorkDay { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Student> Students { get; set; }
    public string Address { get; set; }
    public string SchoolId { get; set; }

    public School School { get; set; }
  }
}