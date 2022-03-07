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
            if (cbx_Workout.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Workout", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(cbx_days.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Day", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txt_Reps.Text == "" || txt_Sets.Text == "" || 
                Convert.ToInt32(txt_Reps.Text) <= 0 || Convert.ToInt32(txt_Sets.Text) <= 0)
            {
                MessageBox.Show("Please Enter number Greater Than 0", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using WorkoutBuilderContext dbContext = new();

                Workout exerciseOfDay = cbx_Workout.SelectedItem as Workout;

                WorkoutOfDay workout = new WorkoutOfDay()
                {
                    WorkoutID = exerciseOfDay.WorkoutID,
                    Day = cbx_days.Text,
                    Sets = Convert.ToInt32(txt_Sets.Text),
                    Reps = Convert.ToInt32(txt_Reps.Text)
                };

                dbContext.WorkoutOfDays.Add(workout);
                dbContext.SaveChanges();
            }
        }
    }
}
