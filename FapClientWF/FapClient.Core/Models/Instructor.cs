﻿using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace FapClient.Core.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Courses = new HashSet<Course>();
        }

        public int InstructorId { get; set; }
        public string InstructorFirstName { get; set; }
        public string InstructorMidName { get; set; }
        public string InstructorLastName { get; set; }

        public string FullName => InstructorFirstName + " " + InstructorMidName + " "+InstructorLastName;

        public string ShortName { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
