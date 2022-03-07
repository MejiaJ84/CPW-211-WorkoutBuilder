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
    }
}
