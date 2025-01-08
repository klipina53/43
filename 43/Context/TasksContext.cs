using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using _43.Classes.Database;
using _43.Models;

namespace _43.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        public TasksContext()
        {
            Database.EnsureCreated();
            Tasks.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(Config.connection, Config.version);
    }
}
