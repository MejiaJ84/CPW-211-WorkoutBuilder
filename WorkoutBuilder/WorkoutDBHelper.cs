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

        /// <summary>
        /// Adds the values from the text box, combo box, and
        /// rich text box to the corresponding
        /// columns in the workout table
        /// </summary>
        /// <param name="workoutPartExerciseBelongsTo"></param>
        /// <param name="addExercise"></param>
        /// <param name="description"></param>
        public static void AddExercise(WorkoutPart workoutPartExerciseBelongsTo, string addExercise, string description)
        {
            WorkoutBuilderContext context = new();
            Workout exercise = new()
            {
                WorkoutName = addExercise,
                WorkoutPartID = workoutPartExerciseBelongsTo.WorkoutPartID,
                WorkoutDescription = description
            };

            context.Workouts.Add(exercise);
            context.SaveChanges();
        }

        /// <summary>
        /// Adds the values from the text box, rich text box, 
        /// and the Part selected from the combo box into to the corresponding
        /// columns in the workout table
        /// </summary>
        /// <param name="currentExercise"></param>
        /// <param name="updatedWorkoutPartId"></param>
        /// <param name="updatedExercise"></param>
        /// <param name="updatedDescription"></param>
        public static void UpdateExercise(Workout currentExercise, WorkoutPart updatedWorkoutPartId, string updatedExercise, string updatedDescription)
        {
            WorkoutBuilderContext context = new();
            context.Attach(currentExercise);
            currentExercise.WorkoutName = updatedExercise;
            currentExercise.WorkoutPartID = updatedWorkoutPartId.WorkoutPartID;
            currentExercise.WorkoutDescription = updatedDescription;
            context.Update(currentExercise);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes the exercise the user selects
        /// from the combo box, from the database
        /// </summary>
        /// <param name="exerciseToDelete"></param>
        public static void DeleteExercise(Workout exerciseToDelete)
        {
            WorkoutBuilderContext context = new();
            context.Remove(exerciseToDelete);
            context.SaveChanges();
        }
    }
}
