using System;
using System.Collections.Generic;

namespace FluentApiCourse.Entities
{
    public class Department
    {
        public int DepartmentID { get; set; } //Primary key
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; private set; } //Navigation property

        public Department()
        {
            this.Courses = new HashSet<Course>();
        }
    }
}
