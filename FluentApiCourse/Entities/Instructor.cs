using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentApiCourse.Entities
{
    public class Instructor
    {
        //public int InstructorID { get; set; } //Primary key
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        [NotMapped]
        public virtual ICollection<Course> Courses { get; private set; } = new List<Course>();

        public Instructor()
        {
        }

        public Instructor(int id, string firstName, string lastName, DateTime hireDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
        }
    }
}
