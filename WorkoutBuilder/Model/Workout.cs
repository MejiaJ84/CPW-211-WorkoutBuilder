using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBuilder.Model
{
    public class Workout
    {
        [Key]
        public int WorkoutID { get; set; }
        
        [Required]
        public string WorkoutName { get; set; }

        
        public int WorkoutPartID { get; set; } // FK for workout part table
        
        public WorkoutPart WorkoutPart { get; set; }

        public string WorkoutDescription { get; set; }

        public List<WorkoutOfDay> WorkoutOfDay { get; set; }
    }
}
