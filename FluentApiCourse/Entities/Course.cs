using System.Collections.Generic;

namespace FluentApiCourse.Entities
{
    public class Course
    {
        public int CourseID { get; set; } //Primary key
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; } //Foreign key
        public virtual Department Department { get; set; } //Navigation property
        public virtual ICollection<Instructor> Instructors { get; private set; } //Navigation property

        public Course()
        {
            this.Instructors = new HashSet<Instructor>();
        }
    }
}
