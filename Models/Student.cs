using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityModule.Model
{
    [Table("StudentInfo")]
    public class Student
    {
        [Column("Id")]
        public int StudentId { get; set; }
        [Column("Name", TypeName = "ntext")]
        [MaxLength(20)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
        public StudentAddress Address { get; set; }
         public IList<StudentCourse> StudentCourses { get; set; }

    }
}