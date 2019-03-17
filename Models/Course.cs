using System;
using System.Collections.Generic;

namespace platzi_asp_net_core.Models
{
  public class Course : ObjSchoolBase
  {
    public TypeWorkDay typeWorkDay { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Student> Students { get; set; }
    public string Address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
  }
}