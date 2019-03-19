using System;
using System.Collections.Generic;

namespace platzi_asp_net_core.Models
{
  public class Student: ObjSchoolBase
  {
    public List<Evaluation> Evaluations { get; set; }
    public string CourseId { get; set; }
    public Course Course { get; set; }
  }
}