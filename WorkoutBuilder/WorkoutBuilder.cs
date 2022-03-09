using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutBuilder.Data;
using WorkoutBuilder.Model;

namespace WorkoutBuilder
{
    public partial class WorkoutBuilder : Form
    {
        public WorkoutBuilder()
        {
            InitializeComponent();
        }

        private void btn_AddWorkout_Click(object sender, EventArgs e)
        {
            AddWorkoutsOfDay addWorkoutForm = new AddWorkoutsOfDay();
            addWorkoutForm.ShowDialog();

            populateWorkouts();
        }

        private void populateWorkouts()
        {
            worktoutsToDays(lbx_Monday, "Monday");
            worktoutsToDays(lbx_Tuesday, "Tuesday");
            worktoutsToDays(lbx_Wednesday, "Wednesday");
            worktoutsToDays(lbx_Thursday, "Thursday");
            worktoutsToDays(lbx_Friday, "Friday");
            worktoutsToDays(lbx_Saturday, "Saturday");
            worktoutsToDays(lbx_Sunday, "Sunday");
        }

        private void worktoutsToDays(ListBox listbox, string day)
        {
            using WorkoutBuilderContext dbContext = new();

            listbox.Items.Clear();

            List<WorkoutOfDay> workoutList = dbContext.WorkoutOfDays
                                             .Where(w => w.Day == day)
                                             .ToList();

            foreach (WorkoutOfDay workout in workoutList)
            {
                listbox.Items.Add(workout);
            }
        }

        private void btn_DeleteWorkout_Click(object sender, EventArgs e)
        {
            deleteWorkout();

            populateWorkouts();
        }

        private void deleteWorkout()
        {
            if(lbx_Monday.SelectedItem != null)
            {
                deleteMethod(lbx_Monday);
            }
            else if (lbx_Tuesday.SelectedItem != null)
            {
                deleteMethod(lbx_Tuesday);
            }
            else if (lbx_Wednesday.SelectedItem != null)
            {
                deleteMethod(lbx_Wednesday);
            }
            else if (lbx_Thursday.SelectedItem != null)
            {
                deleteMethod(lbx_Thursday);
            }
            else if (lbx_Friday.SelectedItem != null)
            {
                deleteMethod(lbx_Friday);
            }
            else if (lbx_Saturday.SelectedItem != null)
            {
                deleteMethod(lbx_Saturday);
            }
            else if (lbx_Sunday.SelectedItem != null)
            {
                deleteMethod(lbx_Sunday);
            }
            else
            {
                MessageBox.Show("Please Select a workout to delete", "Error"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMethod(ListBox listBox)
        {
            using WorkoutBuilderContext dbContext = new();
            WorkoutOfDay workoutToDelete = listBox.SelectedItem as WorkoutOfDay;
            dbContext.WorkoutOfDays.Remove(workoutToDelete);
            dbContext.SaveChanges();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkoutBuilder_Load(object sender, EventArgs e)
        {
            populateWorkouts();
        }
    }
}
