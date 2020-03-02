using System.ComponentModel.DataAnnotations;

namespace EntityModule.Model
{
    public class Course
    {
        [Key()]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }

}