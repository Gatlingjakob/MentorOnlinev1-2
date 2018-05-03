using Microsoft.EntityFrameworkCore;
using MentorOnlinev1.Models.Entities;

namespace MentorOnlinev1.Models
{
    public class MentorDbContext : DbContext
    {
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./MentorOnlinev1.db");
        } 
        
    }
    
}