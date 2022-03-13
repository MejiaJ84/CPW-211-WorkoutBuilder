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
        /// Updates the muscle group selected from the combo box
        /// and updates it with the value from the text box
        /// </summary>
        /// <param name="workoutPartToUpdate"></param>
        /// <param name="updatedWorkokutPart"></param>
        public static void UpateMuscleGroup(WorkoutPart workoutPartToUpdate, string updatedWorkokutPart)
        {
            WorkoutBuilderContext context = new();
            workoutPartToUpdate.MuscleGroup = updatedWorkokutPart;
            context.Update(workoutPartToUpdate);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes the muscle group the user selects
        /// from the combo box, from the database
        /// </summary>
        /// <param name="partToDelete"></param>
        public static void DeleteMuscleGroup(WorkoutPart partToDelete)
        {
            WorkoutBuilderContext context = new();
            context.Remove(partToDelete);
            context.SaveChanges();
        }
    }
}
