using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityModule.Model
{
    public class Student
    {
        [Key()]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int GradesGradeId { get; set; }

    }
}