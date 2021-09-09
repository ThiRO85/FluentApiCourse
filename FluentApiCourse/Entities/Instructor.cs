using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentApiCourse.Entities
{
    public class Instructor
    {
        public int InstructorID { get; set; } //Primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        [NotMapped]
        public virtual ICollection<Course> Courses { get; private set; }

        public Instructor()
        {
            this.Courses = new List<Course>();
        }
    }
}
