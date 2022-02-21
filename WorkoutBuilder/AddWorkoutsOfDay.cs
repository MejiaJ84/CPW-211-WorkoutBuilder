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
    public partial class AddWorkoutsOfDay : Form
    {
        public AddWorkoutsOfDay()
        {
            InitializeComponent();
        }

        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private void AddWorkoutsOfDay_Load(object sender, EventArgs e)
        {
            InitializeComboBoxDays();
        }

        private void InitializeComboBoxDays()
        {
            foreach (string day in days)
            {
                cbx_days.Items.Add(day);
            }
        }
    }
}
