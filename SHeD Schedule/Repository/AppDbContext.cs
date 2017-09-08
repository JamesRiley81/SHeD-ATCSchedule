
using Microsoft.EntityFrameworkCore;
using SHeDSchedule.Models;

namespace SHeDSchedule.Repository
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Schedule.db");
        }   
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Monday> Monday { get; set; }
        public DbSet<Tuesday> Tuesday { get; set; }
        public DbSet<Wednesday> Wednesday { get; set; }
        public DbSet<Thursday> Thursday { get; set; }
        public DbSet<Friday> Friday { get; set; }
    }
}
