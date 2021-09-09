using System;
using System.ComponentModel.DataAnnotations;

namespace FluentApiCourse.Entities
{
    public class OfficeAsignment
    {
        //[Key()]
        //public Int32 InstructorID { get; set; } //Specifying InstructorID as a primary
        public int Id { get; set; }
        public string Location { get; set; }

        //[Timestamp]
        //public Byte[] TimeStamp { get; set; } //When Entity Framework sees Timestamp attribute...
                                              //... it configures ConcurrencyCheck and DatabaseGeneratedPattern=Computed
        public virtual Instructor Instructor { get; set; } //Navigation property

        public OfficeAsignment()
        {
        }

        public OfficeAsignment(int id, string location, Instructor instructor)
        {
            Id = id;
            Location = location;
            Instructor = instructor;
        }
    }
}
