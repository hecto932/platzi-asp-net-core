using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platzi_asp_net_core.Models
{
  public class Course : ObjSchoolBase
  {
    [Required(ErrorMessage="The course name is required")]
    [StringLength(5, ErrorMessage="The course must have maximum 5 characteres")]
    public override string Name { get; set; }
    public TypeWorkDay typeWorkDay { get; set; }
    public List<Subject> Subjects { get; set; }
    public List<Student> Students { get; set; }
    
    [Display(Prompt="The address", Name = "Address")]
    [Required(ErrorMessage="The address is mandatory")]
    [MinLength(10, ErrorMessage="The address es too short")]
    public string Address { get; set; }
    public string SchoolId { get; set; }

    public School School { get; set; }
  }
}