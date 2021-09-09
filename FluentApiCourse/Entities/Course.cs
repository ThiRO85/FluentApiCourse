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
        public virtual ICollection<Instructor> Instructors { get; private set; } = new List<Instructor>(); //Navigation property

        public Course()
        {
        }

        public Course(int courseID, string title, int credits, int departmentID, Department department)
        {
            CourseID = courseID;
            Title = title;
            Credits = credits;
            DepartmentID = departmentID;
            Department = department;
        }
    }
}
