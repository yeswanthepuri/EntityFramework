using System;
using Microsoft.EntityFrameworkCore;

namespace EntityModule.Model
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=SchoolDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //This is to explain Fluid Pattern
            modelBuilder.Entity<Student>().
                        Property(s => s.StudentId).
                        HasColumnName("Id").
                        HasDefaultValue(0).
                        IsRequired();
            //One to many example
            modelBuilder.Entity<Student>()
                        .HasOne<Grade>(x => x.Grade)
                        .WithMany(g => g.Students)
                        .HasForeignKey(s => s.GradeId);
            //Configuring cascading Delete 
            modelBuilder.Entity<Grade>()
                        .HasMany<Student>(g => g.Students)
                        .WithOne(s => s.Grade)
                        .HasForeignKey(s => s.GradeId)
                        .OnDelete(DeleteBehavior.Cascade);
            //Configuring One to one relationship
            modelBuilder.Entity<Student>()
                        .HasOne<StudentAddress>(s => s.Address)
                        .WithOne(ad => ad.Student)
                        .HasForeignKey<StudentAddress>(ad => ad.StudentAddressId);
            //Many to Many relation ship
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            /*Shadow Property: 
            1 when you don't want to expose database columns on the mapped entities, such as the scenario discussed above
            
            2 When you don't want to expose foreign key property and want to manage relationship only using 
            navigation properties. The foreign key property will be shadow property and mapped to the 
            database column but will not be exposed as a property of an entity. 
            */
                modelBuilder.Entity<Student>().Property<DateTime>("CreatedDate");
                modelBuilder.Entity<Student>().Property<DateTime>("UpdatedDate");
        }
    }

}