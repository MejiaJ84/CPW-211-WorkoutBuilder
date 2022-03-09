using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuilder.Data;
using WorkoutBuilder.Model;

namespace WorkoutBuilder
{
    public static class WorkoutDBHelper
    {
        /// <summary>
        /// Adds the value from the group text box
        /// to the muscle group table in the database.
        /// <param name="muscleGroupToAdd">The group box text box</param>
        /// </summary>
        /// <param name="muscleGroupName"></param>
        public static void AddMuscleGroup(string muscleGroupName)
        {
            WorkoutBuilderContext context = new();
            WorkoutPart muscleGroup = new()

            {
                MuscleGroup = muscleGroupName
            };
            context.WorkoutParts.Add(muscleGroup);
            context.SaveChanges();
        }

        /// <summary>
        /// Searches the workouts part table for data matching
        /// the WorkoutPart object passed in and updates it with the value of
        /// the string
        /// </summary>
        /// <param name="updatedMuscleGroup"> The value obtained from the combo box</param>
        public static void UpdateMuscleGroup(WorkoutPart workoutPartToUdate, string updatedWorkoutPart)
        {
            WorkoutBuilderContext context = new();
            workoutPartToUdate.MuscleGroup = updatedWorkoutPart;
            context.Update(workoutPartToUdate);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes the muscle group the user selects
        /// from the combo box, from the database
        /// </summary>
        /// <param name="workoutPartToDelete"></param>
        public static void DeleteMuscleGroup(WorkoutPart workoutPartToDelete)
        {
            WorkoutBuilderContext context = new();
            context.Remove(workoutPartToDelete);
            context.SaveChanges();
        }

    }
}
