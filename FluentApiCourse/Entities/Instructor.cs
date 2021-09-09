using System;
using System.Collections.Generic;

namespace FluentApiCourse.Entities
{
    public class Instructor
    {
        public int InstructorID { get; set; } //Primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public ICollection<Course> Courses { get; private set; }

        public Instructor()
        {
            this.Courses = new List<Course>();
        }
    }
}
