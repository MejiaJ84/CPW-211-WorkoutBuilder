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
    public partial class AddWorkoutsOfDay : Form
    {
        public AddWorkoutsOfDay()
        {
            InitializeComponent();
        }

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private void AddWorkoutsOfDay_Load(object sender, EventArgs e)
        {
            InitializeCOmboBoxWorkout();
            InitializeComboBoxDays();
        }

        private void InitializeCOmboBoxWorkout()
        {
            using WorkoutBuilderContext dbContext = new();

            List<Workout> allWorkouts = dbContext.Workouts.ToList();

            foreach (Workout workout in allWorkouts)
            {
                cbx_Workout.Items.Add(workout);
            }
        }

        private void InitializeComboBoxDays()
        {
            foreach (string day in days)
            {
                cbx_days.Items.Add(day);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValid()
        {
            if (cbx_Workout.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Workout", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cbx_days.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Day", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txt_Reps.Text == null || txt_Sets.Text == null || 
                Convert.ToInt32(txt_Reps.Text) <= 0 || Convert.ToInt32(txt_Sets.Text) <= 0)
            {
                MessageBox.Show("Please Enter number greater than 0", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
