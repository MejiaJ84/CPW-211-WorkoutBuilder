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

        private void tsmAddmuscleGroup_Click(object sender, EventArgs e)
        {
            gbAddUpdateDelete.Text = "Add Muscle Group";
            label1.Text = "Enter Muscle Group to add to the database.";
            gbAddUpdateDelete.Tag = "AddMG";
            btntest1.Text = "Add to Muscle Groups";
            gbAddUpdateDelete.Visible = true;

        }

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
    }
}