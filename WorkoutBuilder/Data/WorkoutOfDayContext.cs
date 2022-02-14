using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuilder.Model;

namespace WorkoutBuilder.Data
{
    public class WorkoutOfDayContext:DbContext
    {
        public WorkoutOfDayContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WorkoutBuilder;Trusted_Connection=True;");
        }

        DbSet<WorkoutOfDay> WorkoutOfDays { get; set; }
    }
}
