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
            worktoutstoDays(lbx_Monday, "Monday");
            worktoutstoDays(lbx_Tuesday, "Tuesday");
            worktoutstoDays(lbx_Wednesday, "Wednesday");
            worktoutstoDays(lbx_Thursday, "Thursday");
            worktoutstoDays(lbx_Friday, "Friday");
            worktoutstoDays(lbx_Saturday, "Saturday");
            worktoutstoDays(lbx_Sunday, "Sunday");
        }

        private void worktoutstoDays(ListBox listbox, string day)
        {
            WorkoutBuilderContext dbContext = new();

            listbox.Items.Clear();

            List<WorkoutOfDay> workoutList = dbContext.WorkoutOfDays
                                             .Where(w => w.Day == day)
                                             .ToList();

            foreach (WorkoutOfDay workout in workoutList)
            {
                listbox.Items.Add(workout);
            }
        }
    }
}
