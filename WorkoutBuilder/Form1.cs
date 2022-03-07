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
                    AddMuscleGroup(txtAddMuscleOrExercise.Text);
                    MessageBox.Show($"{txtAddMuscleOrExercise.Text} added successfully!", "Success", MessageBoxButtons.OK);
                    txtAddMuscleOrExercise.Clear();
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.UpdateMuscleGroup)
                {
                    WorkoutPart workoutPartToUpdate = cbUpdateDelete.SelectedItem as WorkoutPart;
                    workoutPartToUpdate.MuscleGroup = txtAddMuscleOrExercise.Text;
                    UpdateMuscleGroup(workoutPartToUpdate);
                    MessageBox.Show($"{workoutPartToUpdate.MuscleGroup} updated successfully!");
                    txtAddMuscleOrExercise.Clear();
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.DeleteMuscleGroup)
                {
                    WorkoutPart workoutPartToDelete = cbUpdateDelete.SelectedItem as WorkoutPart;
                    DialogResult confirmation = MessageBox.Show($"Are you sure you want to delete {workoutPartToDelete.MuscleGroup}?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirmation == DialogResult.Yes)
                    {
                        DeleteMuscleGroup(workoutPartToDelete);
                        MessageBox.Show($"{workoutPartToDelete.MuscleGroup} has been deleted.");
                    }
                }

                if (_currentOp == CurrentWorkoutBuilderOperation.AddExercise)
                {
                    WorkoutPart exerciseBelongsToThisMuscleGroup = cbUpdateDelete.SelectedItem as WorkoutPart;
                    AddExercise(txtAddMuscleOrExercise.Text, exerciseBelongsToThisMuscleGroup, rtxtExerciseDescription.Text);
                    MessageBox.Show($"{txtAddMuscleOrExercise.Text} added successfully!", "Success", MessageBoxButtons.OK);
                    txtAddMuscleOrExercise.Clear();
                    rtxtExerciseDescription.Clear();
                }
            }
        }

        /// <summary>
        /// If Add Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and make the Group Box and text box visible
        /// and make the combo box invisible.         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddmuscleGroup_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentWorkoutBuilderOperation.AddMuscleGroup;
            SetGroupBox("Add", "Enter Muscle Group you want to add.", "Add Muscle Groups");
            MakeInvisible(cbUpdateDelete);
            MakeInvisible(rtxtExerciseDescription);
            MakeVisible(gbAddUpdateDelete);
            MakeVisible(txtAddMuscleOrExercise);
        }

        /// <summary>
        /// If Update Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// and make the Group Box and combo box visible
        /// and make the text box invisible.
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
            MakeVisible(cbUpdateDelete);
            MakeVisible(gbAddUpdateDelete);
            MakeVisible(txtAddMuscleOrExercise);
        }

        /// <summary>
        /// If Update Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// make the Group Box and combo box visible
        /// and the text box invisible.
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
            MakeVisible(cbUpdateDelete);
            MakeVisible(gbAddUpdateDelete);
        }

        /// <summary>
        /// If Add Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Sets the CurrentWorkoutBuilder operation for the button conditions,
        /// make the Group Box, text box and the combo box visible.
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
            MakeVisible(cbUpdateDelete);
            MakeVisible(gbAddUpdateDelete);
            MakeVisible(rtxtExerciseDescription);
            MakeVisible(lblExerciseDescription);
        }

        /// <summary>
        /// Adds the value from the group text box
        /// to the muscle group table in the database.
        /// </summary>
        /// <param name="muscleGroupToAdd">The group box text box</param>
        private void AddMuscleGroup(string muscleGroupToAdd)
        {
            WorkoutBuilderContext context = new();
            WorkoutPart muscleGroup = new()
            {
                MuscleGroup = muscleGroupToAdd
            };
            context.WorkoutParts.Add(muscleGroup);
            context.SaveChanges();
        }

        /// <summary>
        /// Searches the workouts part table for data matching
        /// the string passed in and updates it with the value from
        /// the text box
        /// </summary>
        /// <param name="updatedMuscleGroup"> The value obtained from the combo box</param>
        private void UpdateMuscleGroup(WorkoutPart updatedMuscleGroup)
        {
            WorkoutBuilderContext context = new();
            context.Update(updatedMuscleGroup);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes the muscle group the user selected
        /// from the combo box, from the database
        /// </summary>
        /// <param name="workoutPartToDelete"></param>
        private void DeleteMuscleGroup(WorkoutPart workoutPartToDelete)
        {
            WorkoutBuilderContext context = new();
            context.Remove(workoutPartToDelete);
            context.SaveChanges();
        }

        /// <summary>
        /// Adds the values from the text box
        /// and from the combo box to the corresponding
        /// columns in the workout table
        /// </summary>
        /// <param name="exerciseToAdd"></param>
        /// <param name="exerciseBelongsToThisMuscleGroup"></param>
        /// <param name="exerciseDescription"></param>
        private void AddExercise(string exerciseToAdd, WorkoutPart exerciseBelongsToThisMuscleGroup, string exerciseDescription)
        {
            WorkoutBuilderContext context = new();
            //int workoutPartId = exerciseBelongsToThisMuscleGroup.WorkoutPartID;
            Workout exercise = new()
            {
                WorkoutName = exerciseToAdd,
                WorkoutPartID = exerciseBelongsToThisMuscleGroup.WorkoutPartID,
                WorkoutDescription = exerciseDescription
            };
            
            context.Workouts.Add(exercise);
            context.SaveChanges();
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
        private static bool IsPresent(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text)) // checks to see if text box is empty or filled with spaces(whitespace)
            {
                return false;
            }
            return true; // Implicit else
        }

        /// <summary>
        /// Checks if all user input fields have valid inputs
        /// </summary>
        /// <returns></returns> True if all fields have valid input
        private bool AreInputFieldsValid()
        {
            bool isDataValid = true;

            if (_currentOp == CurrentWorkoutBuilderOperation.AddMuscleGroup || _currentOp == CurrentWorkoutBuilderOperation.AddExercise)
            {
                if ( !IsPresent(txtAddMuscleOrExercise) )
                {
                    ShowError("Please enter data.");
                    isDataValid = false;
                }
            }

            if (_currentOp == CurrentWorkoutBuilderOperation.UpdateMuscleGroup)
            {
                if ( !IsPresent(txtAddMuscleOrExercise) )
                {
                    ShowError("Please enter updated data.");
                    isDataValid = false;
                }
                
                if (cbUpdateDelete.SelectedIndex < 0)
                {
                    ShowError("Please make you selection from the drop down menu.");
                    isDataValid = false;
                }
                
            }
                
            return isDataValid;
       
                        

            // TODO: add validation to check if item isnt already in database when adding and if item is in database when updating/deleting.

            
        }

        /// <summary>
        /// When an input is invalid this method pops up an error box
        /// </summary>
        /// <param name="errMsg"></param>
        private void ShowError(string errMsg)
        {
            MessageBox.Show(errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbUpdateDelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        




        // TODO:
        // Exercise: add, update and delete functionality
        // Validation
        // Re-factor
    }
}