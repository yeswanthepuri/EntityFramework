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
            var context = new SchoolContext();
            //Eager Loading
            // var studentWithGrade = context.Grades.FromSqlRaw("Select * from Grades where Grade ={0}","A")
            //                         .Include(s => s.Students)
            //                         .FirstOrDefault();

            //Lazy Loading is not supported by EF core.
            //Projection Query
            var grade = context.Grades.
            Where(x => x.Grade == getName()).Select(s =>
                new
                {
                    grade = s,
                    students =s.Students

                }
            ).FirstOrDefault();

            Console.ReadLine();
        }

        public static string getName()
        {
            return "A";
        }

    }
}
