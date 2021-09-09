using System;
using System.ComponentModel.DataAnnotations;

namespace FluentApiCourse.Entities
{
    public class OfficeAsignment
    {
        [Key()]
        public Int32 InstructorID { get; set; } //Specifying InstructorID as a primary
        public string Location { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; } //When Entity Framework sees Timestamp attribute...
                                              //... it configures ConcurrencyCheck and DatabaseGeneratedPattern=Computed
        public virtual Instructor Instructor { get; set; } //Navigation property
    }
}
