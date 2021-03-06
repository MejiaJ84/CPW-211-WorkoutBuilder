using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuilder.Model;

namespace WorkoutBuilder.Data
{
    public class WorkoutBuilderContext:DbContext
    {

        public WorkoutBuilderContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WorkoutBuilder;Trusted_Connection=True;");
        }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutOfDay> WorkoutOfDays { get; set; }
        public DbSet<WorkoutPart> WorkoutParts { get; set; }
    }
}
