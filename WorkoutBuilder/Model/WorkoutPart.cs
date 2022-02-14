using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBuilder.Model
{
    public class WorkoutPart
    {
        [Key]
        public int WorkoutPartID { get; set; }
        [Required]
        public string MuscleGroup { get; set; }

        public List<Workout> Workouts { get; set; }
    }
}
