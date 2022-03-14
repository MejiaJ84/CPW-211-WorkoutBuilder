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
        /// <summary>
        /// The unique ID for each workout
        /// </summary>
        [Key]
        public int WorkoutID { get; set; }
        
        /// <summary>
        /// Name of the workout
        /// </summary>
        [Required]
        public string WorkoutName { get; set; }

        /// <summary>
        /// Foreign Key referenced from the WorkoutPart class,
        /// which refers to workout part that workout belongs to
        /// </summary>
        public int WorkoutPartID { get; set; }
        public WorkoutPart WorkoutPart { get; set; }
        
        /// <summary>
        /// Description of the workouts
        /// </summary>
        public string WorkoutDescription { get; set; }

        public List<WorkoutOfDay> WorkoutOfDay { get; set; }


        public override string ToString()
        {
            return WorkoutName;
        }
    }
}
