using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBuilder.Data
{
    public class WorkoutContext:DbContext
    {

        public WorkoutContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WorkoutBuilder;Trusted_Connection=True;");
        }
    }
}
