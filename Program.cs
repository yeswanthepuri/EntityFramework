using System;
using EntityModule.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityModule
{
    class Program
    {
        static void Main(string[] args)
        {
            // using (var context = new SchoolContext())
            // {
            //     // var grade = context.Grades.
            //     // Where(x => x.Grade == getName()).Include("Students").FirstOrDefault();
            //     var 
            //     if (grade != null)
            //     {
            //         Console.WriteLine($"{grade.GradeName}, {grade?.Students.FirstOrDefault().Name}");
            //     }
            // }
            //var context = new SchoolContext();
            //Eager Loading
            // var studentWithGrade = context.Grades.FromSqlRaw("Select * from Grades where Grade ={0}","A")
            //                         .Include(s => s.Students)
            //                         .FirstOrDefault();

            //Lazy Loading is not supported by EF core.
            //In case if there is multiple relations and in eager loading we can also make use .ThenInclude(g => g.Teachers)
            //this is used in case if there is a  .Include(s => s.Grade)
            //               .ThenInclude(g => g.Teachers)
            //Projection Query
            // var grade = context.Grades.
            // Where(x => x.Grade == getName()).Select(s =>
            //     new
            //     {
            //         grade = s,
            //         students =s.Students

            //     }
            // ).FirstOrDefault();
            //Insert Data
            // var context = new SchoolContext();
            // var std = new Student()
            // {
            //     Name = "Yeswanth",
            //     GradesGradeId = 1
            // };
            // context.Students.Add(std);
            // // or in case if you want a generic way of doing things then make use of this.
            // // context.Add<Student>(std);
            // context.SaveChanges();
            //Updating Data
            // using (var context = new SchoolContext())
            // {
            //     var std = context.Students.First<Student>();
            //     std.Name = "Krithvika E";
            //     context.SaveChanges();
            // }
            // using (var context = new SchoolContext())
            // {
            //     var std = context.Students.First<Student>(x => x.Name == "Yeswanth");
            //     context.Students.Remove(std);
            //     // or
            //     // context.Remove<Student>(std);
            //     context.SaveChanges();
            // }
            // Console.ReadLine();
        }

        public static string getName()
        {
            return "A";
        }

    }
}
