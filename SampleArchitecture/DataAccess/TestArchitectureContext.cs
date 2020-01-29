using System;
using Microsoft.EntityFrameworkCore;
using TestArchitecture.Domain;

namespace TestArchitecture.DataAccess
{
    public class TestArchitectureContext:DbContext
    {
        public TestArchitectureContext(DbContextOptions options) : base(options)
        {
            
           Database.EnsureCreated();
        }
       
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Teacher tch = new Teacher();
            //tch.Id
            //modelBuilder.Entity<Teacher>().HasData(new Teacher(1)
            //{
            //    //Id =1,
            //    //Id=  1,

            //    Name = "tech1",
            //    Subject = "Comp"
            //}, new Teacher(2)
            //{
            //    //Id = 2,
            //    Name = "tech2",
            //    Subject = "Eng"
            //});


        }
        
    }
}