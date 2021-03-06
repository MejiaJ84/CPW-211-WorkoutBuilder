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
        /// <summary>
        /// Unique ID that each part has.
        /// </summary>
        [Key]
        public int WorkoutPartID { get; set; }

        /// <summary>
        /// Name of the muscle group
        /// </summary>
        [Required]
        public string MuscleGroup { get; set; }

        public List<Workout> Workouts { get; set; }

        public override string ToString()
        {
            return MuscleGroup;
        }
    }
}
