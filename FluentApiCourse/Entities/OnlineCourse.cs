namespace FluentApiCourse.Entities
{
    public partial class OnlineCourse : Course
    {
        public string URL { get; set; }

        public OnlineCourse()
        {
        }

        public OnlineCourse(string uRL)
        {
            URL = uRL;
        }
    }
}
