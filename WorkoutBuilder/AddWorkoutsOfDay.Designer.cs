namespace WorkoutBuilder
{
    partial class AddWorkoutsOfDay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Workout = new System.Windows.Forms.Label();
            this.lbl_DayOfWeek = new System.Windows.Forms.Label();
            this.lbl_Reps = new System.Windows.Forms.Label();
            this.lbl_Sets = new System.Windows.Forms.Label();
            this.cbx_Workout = new System.Windows.Forms.ComboBox();
            this.cbx_days = new System.Windows.Forms.ComboBox();
            this.txt_Sets = new System.Windows.Forms.TextBox();
            this.txt_Reps = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Workout
            // 
            this.lbl_Workout.AutoSize = true;
            this.lbl_Workout.Location = new System.Drawing.Point(90, 82);
            this.lbl_Workout.Name = "lbl_Workout";
            this.lbl_Workout.Size = new System.Drawing.Size(68, 20);
            this.lbl_Workout.TabIndex = 0;
            this.lbl_Workout.Text = "Workout";
            // 
            // lbl_DayOfWeek
            // 
            this.lbl_DayOfWeek.AutoSize = true;
            this.lbl_DayOfWeek.Location = new System.Drawing.Point(90, 138);
            this.lbl_DayOfWeek.Name = "lbl_DayOfWeek";
            this.lbl_DayOfWeek.Size = new System.Drawing.Size(97, 20);
            this.lbl_DayOfWeek.TabIndex = 1;
            this.lbl_DayOfWeek.Text = "Day of Week";
            // 
            // lbl_Reps
            // 
            this.lbl_Reps.AutoSize = true;
            this.lbl_Reps.Location = new System.Drawing.Point(90, 274);
            this.lbl_Reps.Name = "lbl_Reps";
            this.lbl_Reps.Size = new System.Drawing.Size(41, 20);
            this.lbl_Reps.TabIndex = 2;
            this.lbl_Reps.Text = "Reps";
            // 
            // lbl_Sets
            // 
            this.lbl_Sets.AutoSize = true;
            this.lbl_Sets.Location = new System.Drawing.Point(90, 207);
            this.lbl_Sets.Name = "lbl_Sets";
            this.lbl_Sets.Size = new System.Drawing.Size(36, 20);
            this.lbl_Sets.TabIndex = 3;
            this.lbl_Sets.Text = "Sets";
            // 
            // cbx_Workout
            // 
            this.cbx_Workout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Workout.FormattingEnabled = true;
            this.cbx_Workout.Location = new System.Drawing.Point(236, 82);
            this.cbx_Workout.Name = "cbx_Workout";
            this.cbx_Workout.Size = new System.Drawing.Size(151, 28);
            this.cbx_Workout.TabIndex = 4;
            // 
            // cbx_days
            // 
            this.cbx_days.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_days.FormattingEnabled = true;
            this.cbx_days.Location = new System.Drawing.Point(236, 138);
            this.cbx_days.Name = "cbx_days";
            this.cbx_days.Size = new System.Drawing.Size(151, 28);
            this.cbx_days.TabIndex = 5;
            // 
            // txt_Sets
            // 
            this.txt_Sets.Location = new System.Drawing.Point(236, 207);
            this.txt_Sets.Name = "txt_Sets";
            this.txt_Sets.Size = new System.Drawing.Size(151, 27);
            this.txt_Sets.TabIndex = 6;
            // 
            // txt_Reps
            // 
            this.txt_Reps.Location = new System.Drawing.Point(236, 274);
            this.txt_Reps.Name = "txt_Reps";
            this.txt_Reps.Size = new System.Drawing.Size(151, 27);
            this.txt_Reps.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(109, 368);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(245, 368);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(94, 29);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // AddWorkoutsOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 470);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Reps);
            this.Controls.Add(this.txt_Sets);
            this.Controls.Add(this.cbx_days);
            this.Controls.Add(this.cbx_Workout);
            this.Controls.Add(this.lbl_Sets);
            this.Controls.Add(this.lbl_Reps);
            this.Controls.Add(this.lbl_DayOfWeek);
            this.Controls.Add(this.lbl_Workout);
            this.Name = "AddWorkoutsOfDay";
            this.Text = "Add Workouts to the Day";
            this.Load += new System.EventHandler(this.AddWorkoutsOfDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Workout;
        private Label lbl_DayOfWeek;
        private Label lbl_Reps;
        private Label lbl_Sets;
        private ComboBox cbx_Workout;
        private ComboBox cbx_days;
        private TextBox txt_Sets;
        private TextBox txt_Reps;
        private Button btn_Add;
        private Button btn_Close;
    }
}