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
            InitializeComboBoxWorkoutPart();
            InitializeComboBoxWorkout();
            InitializeComboBoxDays();
            
        }

        /// <summary>
        /// Puts workout parts in the comboboxes for user to select
        /// </summary>
        private void InitializeComboBoxWorkoutPart()
        {
            using WorkoutBuilderContext dbContext = new();

            List<WorkoutPart> allWorkoutParts = dbContext.WorkoutParts.ToList();

            foreach (WorkoutPart workoutParts in allWorkoutParts)
            {
                cbx_WorkoutPart.Items.Add(workoutParts);
            }
        }

        /// <summary>
        /// Puts all workouts in the list for users to select
        /// </summary>
        private void InitializeComboBoxWorkout()
        {
            using WorkoutBuilderContext dbContext = new();

            List<Workout> allWorkouts = dbContext.Workouts.ToList();

            foreach (Workout workout in allWorkouts)
            {
                cbx_Workout.Items.Add(workout);
            }
        }

        /// <summary>
        /// puts workouts that only belongs to selected muscle group for users to select
        /// </summary>
        /// <param name="WorkoutPartid"></param>
        private void InitializeComboBoxWorkout(int WorkoutPartid)
        {
            using WorkoutBuilderContext dbContext = new();

            cbx_Workout.Items.Clear();

            List<Workout> allWorkouts = dbContext.Workouts
                                        .Where(w => w.WorkoutPartID == WorkoutPartid)
                                        .ToList();

            foreach (Workout workout in allWorkouts)
            {
                cbx_Workout.Items.Add(workout);
            }
        }

        /// <summary>
        /// puts days in the list
        /// </summary>
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

        /// <summary>
        /// validate the components in the input boxes before adding a workout
        /// </summary>
        /// <returns>It will return true if validation went through without problem.</returns>
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

                this.Close();
            }
        }

        private void cbx_WorkoutPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkoutPart selectedWorkoutPart = cbx_WorkoutPart.SelectedItem as WorkoutPart;
            InitializeComboBoxWorkout(selectedWorkoutPart.WorkoutPartID);
        }
    }
}
