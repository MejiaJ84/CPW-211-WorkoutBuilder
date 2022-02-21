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
                addMuscleGroup(txtAddMuscleOrExercise);
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
            gbAddUpdateDelete.Text = "Add Muscle Group";
            label1.Text = "Enter Muscle Group to add to the database.";
            gbAddUpdateDelete.Tag = "AddMG";
            btnAddUpdate.Text = "Add to Muscle Groups";
            gbAddUpdateDelete.Visible = true;

        }

        /// <summary>
        /// Adds the value from the group text box
        /// to the muscle group table in the database.
        /// </summary>
        /// <param name="text">The group box text box</param>
        public void addMuscleGroup(TextBox text)
        {
            WorkoutBuilderContext context = new();
            WorkoutPart muscleGroup = new()
            {
                MuscleGroup = text.Text
            };
            context.WorkoutParts.Add(muscleGroup);
            context.SaveChanges();
            
        }

        private void tsmWorkoutBuilder_Click(object sender, EventArgs e)
        {
            AddWorkoutsOfDay AddWorkoutsOfDayForm = new AddWorkoutsOfDay();
            AddWorkoutsOfDayForm.ShowDialog();
        }

        // TODO:
        // Exercise: add, update and delete functionality
        // Muscle Group: update and delete functionality 
    }
}