using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuilder.Data;

namespace WorkoutBuilder.Model
{
    public class WorkoutOfDay
    {
        /// <summary>
        /// Unique ID for each workout in the workouts of day table.
        /// </summary>
        [Key]
        public int WorkoutOfDayID { get; set; }

        /// <summary>
        /// workout ID that is referenced from workout table
        /// </summary>
        public int WorkoutID { get; set; }
        [ForeignKey("WorkoutID")]
        public Workout Workouts { get; set; }
        
        /// <summary>
        /// Day that the workout belongs to.
        /// </summary>
        [Required]
        public string Day { get; set; }

        /// <summary>
        /// number of sets
        /// </summary>
        [Range(0, int.MaxValue)]
        public int Sets { get; set; }

        /// <summary>
        /// number of reps they have to perform
        /// </summary>
        [Range(0, int.MaxValue)]
        public int Reps { get; set; }

        public string workoutName(int WorkoutID)
        {
            using WorkoutBuilderContext dbContext = new();

            List<Workout> allWorkouts = dbContext.Workouts.ToList();

            foreach (Workout workout in allWorkouts)
            {
                if(workout.WorkoutID == WorkoutID)
                {
                    return workout.WorkoutName;
                }
            }

            return String.Empty;
        }

        public override string ToString()
        {
            return workoutName(WorkoutID) + " " + Sets + "Set(s) " + Reps + "Rep(s)";
        }
    }
}
