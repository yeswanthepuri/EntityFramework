using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModule.Model
{
    public class Grades
    {
        [Key()]
        public int GradeId { get; set; }
        public string Grade { get; set; }
        public string GradeName { get; set; }
        public List<Student> Students { get; set; }
    }

}