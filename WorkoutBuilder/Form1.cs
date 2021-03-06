using System.Data;
using WorkoutBuilder.Data;
using WorkoutBuilder.Model;

namespace WorkoutBuilder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        enum CurrentWorkoutBuilderOperation
        {
            AddMuscleGroup, UpdateMuscleGroup, DeleteMuscleGroup, AddExercise, UpdateExercise, DeleteExercise, None
        }

        private CurrentWorkoutBuilderOperation _currentOp;

        /// <summary>
        /// Adds, updates, or deletes muscle groups/exercises depending on which menu item 
        /// was selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btntest1_Click(object sender, EventArgs e)
        {
            if (AreInputFieldsValid())
            {
                if (_currentOp == CurrentWorkoutBuilderOperation.AddMuscleGroup)
                {

                    WorkoutDBHelper.AddMuscleGroup(txtAddMuscleOrExercise.Text);
                    MessageBox.Show($"{txtAddMuscleOrExercise.Text} added successfully!", "Success", MessageBoxButtons.OK);
                    txtAddMuscleOrExercise.Clear();
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.UpdateMuscleGroup)
                { 
                    WorkoutPart updateWorkoutPart = cbUpdateDelete.SelectedItem as WorkoutPart;
                    WorkoutDBHelper.UpateMuscleGroup(updateWorkoutPart, txtAddMuscleOrExercise.Text);
                    MessageBox.Show($"{txtAddMuscleOrExercise.Text} updated successfully!");
                    txtAddMuscleOrExercise.Clear();
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.DeleteMuscleGroup)
                {
                    WorkoutPart workoutPartToDelete = cbUpdateDelete.SelectedItem as WorkoutPart;
                    DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete {workoutPartToDelete.MuscleGroup}?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirmation == DialogResult.Yes)
                    {
                        WorkoutDBHelper.DeleteMuscleGroup(workoutPartToDelete);
                        MessageBox.Show($"{workoutPartToDelete.MuscleGroup} has been deleted.");
                    }
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.AddExercise)
                {
                    WorkoutPart part = cbUpdateDelete.SelectedItem as WorkoutPart;
                    WorkoutDBHelper.AddExercise(part, txtAddMuscleOrExercise.Text, rtxtExerciseDescription.Text);
                    MessageBox.Show($"{txtAddMuscleOrExercise.Text} added successfully!", "Success", MessageBoxButtons.OK);
                    txtAddMuscleOrExercise.Clear();
                    rtxtExerciseDescription.Clear();
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.UpdateExercise)
                {
                    WorkoutPart updatedWorkoutPartId = cbUpdateDelete.SelectedItem as WorkoutPart;
                    Workout currentExercise = cbUpdateDeleteExercise.SelectedItem as Workout;
                    
                    WorkoutDBHelper.UpdateExercise(currentExercise, updatedWorkoutPartId, txtAddMuscleOrExercise.Text, rtxtExerciseDescription.Text);
                    
                    MessageBox.Show($"{txtAddMuscleOrExercise.Text} Updated successfully!", "Success", MessageBoxButtons.OK);
                    txtAddMuscleOrExercise.Clear();
                    rtxtExerciseDescription.Clear();
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.DeleteExercise)
                {
                    Workout exerciseToDelete = cbUpdateDeleteExercise.SelectedItem as Workout;
                    DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete {exerciseToDelete.WorkoutName}?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirmation == DialogResult.Yes)
                    {
                        WorkoutDBHelper.DeleteExercise(exerciseToDelete);
                        MessageBox.Show($"{exerciseToDelete.WorkoutName} has been deleted.");
                    }
                }
            }
        }

        /// <summary>
        /// If Add Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and makes the needed Controls visible while
        /// making unneeded ones invisible.         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddmuscleGroup_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentWorkoutBuilderOperation.AddMuscleGroup;
            SetGroupBox("Add", "Enter Muscle Group you want to add.", "Add Muscle Groups");
            MakeInvisible(cbUpdateDelete);
            MakeInvisible(rtxtExerciseDescription);
            MakeInvisible(cbUpdateDeleteExercise);
            MakeInvisible(lblExerciseDescription);
            MakeVisible(gbAddUpdateDelete);
            MakeVisible(txtAddMuscleOrExercise);
        }

        /// <summary>
        /// If Update Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and makes the needed Controls visible while
        /// making unneeded ones invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmUpdateMG_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentWorkoutBuilderOperation.UpdateMuscleGroup;
            WorkoutBuilderContext context = new();
            List<WorkoutPart> workoutParts = context.WorkoutParts.ToList();
            SetGroupBox("Update", "Select a Muscle Group to Update", "Update");
            FillUpdateDeleteComboBox(workoutParts);
            MakeInvisible(rtxtExerciseDescription);
            MakeInvisible(cbUpdateDeleteExercise);
            MakeInvisible(lblExerciseDescription);
            MakeVisible(cbUpdateDelete);
            MakeVisible(gbAddUpdateDelete);
            MakeVisible(txtAddMuscleOrExercise);
        }

        /// <summary>
        /// If Delete Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and makes the needed Controls visible while
        /// making unneeded ones invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmDeleteMG_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentWorkoutBuilderOperation.DeleteMuscleGroup;
            WorkoutBuilderContext context = new();
            List<WorkoutPart> workoutParts = context.WorkoutParts.ToList();
            FillUpdateDeleteComboBox(workoutParts);
            SetGroupBox("Delete", "Select a Muscle Group to Delete", "Delete");
            MakeInvisible(txtAddMuscleOrExercise);
            MakeInvisible(rtxtExerciseDescription);
            MakeInvisible(cbUpdateDeleteExercise);
            MakeInvisible(lblExerciseDescription);
            MakeVisible(cbUpdateDelete);
            MakeVisible(gbAddUpdateDelete);
        }

        /// <summary>
        /// If Add Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and makes the needed Controls visible while
        /// making unneeded ones invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddExercise_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentWorkoutBuilderOperation.AddExercise;
            SetGroupBox("Add", "Enter Exercise you want to add and select the muscle group it belongs to.", "Add Exercise");
            WorkoutBuilderContext context = new();
            List<WorkoutPart> workoutParts = context.WorkoutParts.ToList();
            FillUpdateDeleteComboBox(workoutParts);
            MakeInvisible(cbUpdateDeleteExercise);
            MakeVisible(txtAddMuscleOrExercise);
            MakeVisible(cbUpdateDelete);
            MakeVisible(rtxtExerciseDescription);
            MakeVisible(lblExerciseDescription);
            MakeVisible(gbAddUpdateDelete);
            rtxtExerciseDescription.Clear();
        }

        /// <summary>
        /// If Update Exercise is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and makes the needed Controls visible while
        /// making unneeded ones invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmUpdateExercise_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentWorkoutBuilderOperation.UpdateExercise;
            SetGroupBox("Update", "Select an exercise you wish to update and its corresponding muscle group.", "Update Exercise");
            WorkoutBuilderContext context = new();
            List<Workout> exercises = context.Workouts.ToList();
            List<WorkoutPart> workoutParts = context.WorkoutParts.ToList();
            FillUpdateDeleteExerciseComboBox(exercises);
            FillUpdateDeleteComboBox(workoutParts);
            MakeInvisible(cbUpdateDelete);
            MakeVisible(cbUpdateDeleteExercise);
            MakeVisible(gbAddUpdateDelete);
            MakeVisible(rtxtExerciseDescription);
            MakeVisible(lblExerciseDescription);
        }

        /// <summary>
        /// If Delete Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and makes the needed Controls visible while
        /// making unneeded ones invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmDeleteExercise_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentWorkoutBuilderOperation.DeleteExercise;
            SetGroupBox("Delete", "Select an exercise you wish to delete", "Delete Exercise");
            WorkoutBuilderContext context = new();
            List<Workout> workouts = context.Workouts.ToList();
            FillUpdateDeleteExerciseComboBox(workouts);
            MakeInvisible(txtAddMuscleOrExercise);
            MakeInvisible(rtxtExerciseDescription);
            MakeInvisible(lblExerciseDescription);
            MakeVisible(cbUpdateDeleteExercise);
            MakeVisible(gbAddUpdateDelete);
        }

        /// <summary>
        /// Sets the values of the Group Box elements
        /// passed to the strings that are passed in
        /// </summary>
        /// <param name="grpBoxText">Value of the Group box text</param>
        /// <param name="lblText">Value the label is to display</param>
        /// <param name="grpBoxTag">the string the tag is to hold</param>
        /// <param name="btnText">Value the button is to display</param>
        private void SetGroupBox(string grpBoxText, string lblText, string btnText)
        {
            gbAddUpdateDelete.Text = grpBoxText;
            lblInstructions.Text = lblText;
            btnAddUpdate.Text = btnText;
        }

        /// <summary>
        /// Fills the exercise combo box
        /// with the appropriate data from the database
        /// </summary>
        /// <param name="list"></param>
        private void FillUpdateDeleteExerciseComboBox(List<Workout> list)
        {
            cbUpdateDeleteExercise.DataSource = list;
            cbUpdateDeleteExercise.DisplayMember = nameof(Workout.WorkoutName);
            cbUpdateDeleteExercise.ValueMember = nameof(Workout.WorkoutID);

        }

        /// <summary>
        /// Fills the muscle group combo box
        /// with the appropriate data from the database
        /// </summary>
        /// <param name="list">list of muscle groups from the database</param>
        private void FillUpdateDeleteComboBox(List<WorkoutPart> list)
        {
            cbUpdateDelete.DataSource = list;
            cbUpdateDelete.DisplayMember = nameof(WorkoutPart.MuscleGroup);
            cbUpdateDelete.ValueMember = nameof(WorkoutPart.WorkoutPartID);
        }

        /// <summary>
        /// Fills exercise description box with data
        /// from the database in case the user doesn't 
        /// want to change the description
        /// </summary>
        private void FillExerciseDescriptionBox()
        {
            Workout exercise = cbUpdateDeleteExercise.SelectedItem as Workout;
            rtxtExerciseDescription.Text = exercise.WorkoutDescription;
        }

        /// <summary>
        /// When a menu item is selected where the Control is 
        /// needed, make it visible.
        /// </summary>
        /// <param name="makeVisible"></param>
        private void MakeVisible(Control makeVisible)
        {
            makeVisible.Visible = true;
        }

        /// <summary>
        /// When a menu item is selected where the Control is 
        /// no longer needed, make it invisible.
        /// </summary>
        private void MakeInvisible(Control makeIinvisible)
        {
            makeIinvisible.Visible = false;
        }

        /// <summary>
        /// Checks to see if there is data in the text box
        /// to send to the database
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        private static bool IsPresent(Control box)
        {
            if (string.IsNullOrWhiteSpace(box.Text)) // checks to see if text box is empty or filled with spaces(whitespace)
            {
                return false;
            }
            return true; // Implicit else
        }

        private void tsmWorkoutBuilder_Click(object sender, EventArgs e)
        {
            WorkoutBuilder workoutBuilderForm = new WorkoutBuilder();
            workoutBuilderForm.ShowDialog();
        }

        /// <summary>
        /// Checks if all user input fields have valid inputs
        /// </summary>
        /// <returns></returns> True if all fields have valid input
        private bool AreInputFieldsValid()
        {
            bool isDataValid = true;

            if (_currentOp == CurrentWorkoutBuilderOperation.AddMuscleGroup)
            {
                if ( !IsPresent(txtAddMuscleOrExercise))
                {
                    ShowError("Please enter a muscle group.");
                    isDataValid = false;
                }
            }

            if (_currentOp == CurrentWorkoutBuilderOperation.UpdateMuscleGroup)
            {
                if (!IsPresent(txtAddMuscleOrExercise))
                {
                    ShowError("Please enter updated data.");
                    isDataValid = false;
                }
            }

            if (_currentOp == CurrentWorkoutBuilderOperation.AddExercise)
            {
                if (!IsPresent(txtAddMuscleOrExercise))
                {
                    ShowError("Please enter an exercise.");
                    isDataValid = false;
                }

                if (!IsPresent(rtxtExerciseDescription))
                {
                    
                    ShowError("Please enter a description.");
                    isDataValid = false;
                    
                }
            }

            if (_currentOp == CurrentWorkoutBuilderOperation.UpdateExercise)
            {

                if (!IsPresent(rtxtExerciseDescription) || !IsPresent(txtAddMuscleOrExercise))
                {
                    ShowError("Please enter updated data.");
                    isDataValid = false;
                }
            }
            return isDataValid;
            // TODO: add validation to check if item isn't already in database when adding and if item is in database when updating/deleting.
        }

        /// <summary>
        /// When an input is invalid this method pops up an error box
        /// </summary>
        /// <param name="errMsg"></param>
        private void ShowError(string errMsg)
        {
            MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Fills the description box with the data pertaining to the 
        /// exercise chosen from the combo box. In case when updating an exercise
        /// only some or no parts of the description need to be changed, the user doesn't
        /// have to re-write the description.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUpdateDeleteExercise_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillExerciseDescriptionBox();
        }

        









        // TODO:
        // Exercise: add, update and delete functionality
        // Validation
        // Re-factor
    }
}