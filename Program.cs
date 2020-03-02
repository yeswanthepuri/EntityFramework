using System;
using EntityModule.Model;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityModule
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var grade = context.Grades.
                Where(x => x.Grade == getName()).Include("Students").FirstOrDefault();
                if (grade != null)
                {
                    Console.WriteLine($"{grade.GradeName}, {grade?.Students.FirstOrDefault().Name}");
                }
            }
            Console.ReadLine();
        }

        public static string getName()
        {
            return "A";
        }

    }
}
