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

        enum CurrentMuscleGroupOperation
        {
            AddMuscleGroup, UpdateMuscleGroup, DeleteMuscleGroup, AddExercise, UpdateExercise, DeleteExercise, None
        }

        private CurrentMuscleGroupOperation _currentOp;

        private void btntest1_Click(object sender, EventArgs e)
        {
            if (AreInputFieldsValid())
            {
                if (_currentOp == CurrentMuscleGroupOperation.AddMuscleGroup)
                {
                    AddMuscleGroup(txtAddMuscleOrExercise.Text);
                    MessageBox.Show("Muscle Group Added Successfully");
                    txtAddMuscleOrExercise.Clear();
                }

                if (_currentOp == CurrentMuscleGroupOperation.UpdateMuscleGroup)
                {
                    if (cbUpdateDelete.SelectedIndex > 0 && !IsPresent(txtAddMuscleOrExercise))
                    {
                        MessageBox.Show("Please select a Muscle Group to update");
                    }
                    
                    WorkoutPart workoutPartToUpdate = cbUpdateDelete.SelectedItem as WorkoutPart;
                    workoutPartToUpdate.MuscleGroup = txtAddMuscleOrExercise.Text;
                    UpdateMuscleGroup(workoutPartToUpdate);
                    MessageBox.Show("Update Successful!");
                    txtAddMuscleOrExercise.Clear();

                }
            }
        }

        /// <summary>
        /// If Add Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Adds a tag to the group box for the button conditions,
        /// and make the Group Box visible.         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmAddmuscleGroup_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentMuscleGroupOperation.AddMuscleGroup;
            SetGroupBox("Add Muscle Group", "Enter Muscle Group to add to the database.", "Add to Muscle Groups");
            MakeGroupBoxVisible();
        }

        /// <summary>
        /// If Update Muscle Group is clicked
        /// Change the text values of the group box items, 
        /// Adds a tag to the group box for the button conditions,
        /// and make the Group Box and combo box visible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmUpdateMG_Click(object sender, EventArgs e)
        {
            _currentOp = CurrentMuscleGroupOperation.UpdateMuscleGroup;
            WorkoutBuilderContext context = new();
            SetGroupBox("Update Muscle Groups", "Select a Muscle Group to Update", "Update");
            MakeGroupBoxVisible();
            List<WorkoutPart> workoutParts = context.WorkoutParts.ToList();
            FillMuscleGroupComboBox(workoutParts);
            DefaultListItem();
            MakeComboBoxVisible();
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
            //workoutParts.MuscleGroup = txtAddMuscleOrExercise.Text;
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
            label1.Text = lblText;
            btnAddUpdate.Text = btnText;
        }

        /// <summary>
        /// Makes the Group box visible
        /// </summary>
        private void MakeGroupBoxVisible()
        {
            gbAddUpdateDelete.Visible=true;
        }

        /// <summary>
        /// Makes the combo box visible
        /// </summary>
        private void MakeComboBoxVisible()
        {
            cbUpdateDelete.Visible = true;
        }

        /// <summary>
        /// Fills the muscle group combo box
        /// with the appropriate data from the database
        /// </summary>
        /// <param name="list">list of muscle groups from the database</param>
        private void FillMuscleGroupComboBox(List<WorkoutPart> list)
        {
            cbUpdateDelete.DataSource = list;
            cbUpdateDelete.DisplayMember = nameof(WorkoutPart.MuscleGroup);
            cbUpdateDelete.ValueMember = nameof(WorkoutPart.WorkoutPartID);
        }

        /// <summary>
        /// Sets the combo box to
        /// the specified default text on initial load
        /// </summary>
        /// <param name="defaultText"></param>
        private void DefaultListItem()
        {
            cbUpdateDelete.SelectedIndex = 0;
        }

        /// <summary>
        /// Checks to see if there is data in the text box
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
            if (!IsPresent(txtAddMuscleOrExercise))
            {
                ShowError("Please enter data");
                isDataValid = false;
            }

            // TODO: add validation to check if item isnt already in database when adding and if item is in database when updating.

            return isDataValid;
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
        // Muscle Group: update and delete functionality 
    }
}