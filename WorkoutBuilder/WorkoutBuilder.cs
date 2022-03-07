using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            throw new NotImplementedException();
        }
    }
}
