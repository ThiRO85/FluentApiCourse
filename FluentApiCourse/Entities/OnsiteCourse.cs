namespace FluentApiCourse.Entities
{
    public partial class OnsiteCourse : Course
    {
        public Details Details { get; set; }

        public OnsiteCourse()
        {
            Details = new Details();
        }
    }
}
