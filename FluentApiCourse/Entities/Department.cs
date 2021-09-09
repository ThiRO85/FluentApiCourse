using System;
using System.Collections.Generic;

namespace FluentApiCourse.Entities
{
    public class Department
    {
        public int Id { get; set; } //Primary key
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; private set; } = new List<Course>(); //Navigation property

        public Department()
        {
        }

        public Department(int id, string name, decimal budget, DateTime startDate, int administrator)
        {
            Id = id;
            Name = name;
            Budget = budget;
            StartDate = startDate;
            Administrator = administrator;
        }
    }
}
