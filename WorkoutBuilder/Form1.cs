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

        private void btntest1_Click(object sender, EventArgs e)
        {
            if (gbAddUpdateDelete.Tag.Equals("AddMG"))
            {
                AddMuscleGroup(txtAddMuscleOrExercise.Text);
                txtAddMuscleOrExercise.Clear();
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
            SetGroupBox("Add Muscle Group", "Enter Muscle Group to add to the database.", "AddMG", "Add to Muscle Groups");
            MakeGroupBoxVisible();
        }

        private void tsmUpdateMG_Click(object sender, EventArgs e)
        {
            using WorkoutBuilderContext context = new();
            SetGroupBox("Update Muscle Groups", "Select a Muscle Group to Update", "UpdateMG", "Update");
            MakeGroupBoxVisible();
            List<WorkoutPart> workoutParts = context.WorkoutParts.ToList();
            FillMuscleGroupComboBox(workoutParts);
            MakeComboBoxVisible();
        }

        /// <summary>
        /// Adds the value from the group text box
        /// to the muscle group table in the database.
        /// </summary>
        /// <param name="muscleGroupToAdd">The group box text box</param>
        public void AddMuscleGroup(string muscleGroupToAdd)
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
        /// Sets the values of the Group Box elements
        /// passed to the strings that are passed in
        /// </summary>
        /// <param name="grpBoxText">Value of the Group box text</param>
        /// <param name="lblText">Value the label is to display</param>
        /// <param name="grpBoxTag">the string the tag is to hold</param>
        /// <param name="btnText">Value the button is to display</param>
        private void SetGroupBox(string grpBoxText, string lblText, string grpBoxTag, string btnText)
        {
            gbAddUpdateDelete.Text = grpBoxText;
            label1.Text = lblText;
            gbAddUpdateDelete.Tag = grpBoxTag;
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

        private void FillMuscleGroupComboBox(List<WorkoutPart> list)
        {
            foreach (WorkoutPart musclegroup in list)
            {
                cbUpdateDelete.Items.Add(musclegroup.MuscleGroup);
            }
        }


        // TODO:
        // Exercise: add, update and delete functionality
        // Muscle Group: update and delete functionality 
    }
}