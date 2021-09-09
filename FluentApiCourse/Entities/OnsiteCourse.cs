namespace FluentApiCourse.Entities
{
    public partial class OnsiteCourse : Course
    {
        public Details Details { get; set; }

        public OnsiteCourse()
        {
        }

        public OnsiteCourse(Details details)
        {
            Details = details;
        }
    }
}
