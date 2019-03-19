using System;
using System.Collections.Generic;

namespace platzi_asp_net_core.Models
{
    public class Subject: ObjSchoolBase
    {
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public List<Evaluation> Evaluations { get; set; }

    }
}