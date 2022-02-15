namespace WorkoutBuilder
{
    partial class Add
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMuscleGroup = new System.Windows.Forms.TextBox();
            this.btnMuscleGroup = new System.Windows.Forms.Button();
            this.lblMuscleGroup = new System.Windows.Forms.Label();
            this.txtAddExercise = new System.Windows.Forms.TextBox();
            this.lblAddExercise = new System.Windows.Forms.Label();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.cbMuscleGroup = new System.Windows.Forms.ComboBox();
            this.btnOpenUpdate = new System.Windows.Forms.Button();
            this.btnOpenWorkoutBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMuscleGroup
            // 
            this.txtMuscleGroup.Location = new System.Drawing.Point(176, 78);
            this.txtMuscleGroup.Name = "txtMuscleGroup";
            this.txtMuscleGroup.Size = new System.Drawing.Size(100, 23);
            this.txtMuscleGroup.TabIndex = 0;
            // 
            // btnMuscleGroup
            // 
            this.btnMuscleGroup.Location = new System.Drawing.Point(315, 78);
            this.btnMuscleGroup.Name = "btnMuscleGroup";
            this.btnMuscleGroup.Size = new System.Drawing.Size(124, 23);
            this.btnMuscleGroup.TabIndex = 1;
            this.btnMuscleGroup.Text = "Add Muscle Group";
            this.btnMuscleGroup.UseVisualStyleBackColor = true;
            // 
            // lblMuscleGroup
            // 
            this.lblMuscleGroup.AutoSize = true;
            this.lblMuscleGroup.Location = new System.Drawing.Point(35, 82);
            this.lblMuscleGroup.Name = "lblMuscleGroup";
            this.lblMuscleGroup.Size = new System.Drawing.Size(106, 15);
            this.lblMuscleGroup.TabIndex = 2;
            this.lblMuscleGroup.Text = "Add Muscle Group";
            this.lblMuscleGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddExercise
            // 
            this.txtAddExercise.Location = new System.Drawing.Point(176, 182);
            this.txtAddExercise.Name = "txtAddExercise";
            this.txtAddExercise.Size = new System.Drawing.Size(100, 23);
            this.txtAddExercise.TabIndex = 3;
            // 
            // lblAddExercise
            // 
            this.lblAddExercise.AutoSize = true;
            this.lblAddExercise.Location = new System.Drawing.Point(47, 189);
            this.lblAddExercise.Name = "lblAddExercise";
            this.lblAddExercise.Size = new System.Drawing.Size(74, 15);
            this.lblAddExercise.TabIndex = 4;
            this.lblAddExercise.Text = "Add Exercise";
            this.lblAddExercise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(480, 185);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(111, 23);
            this.btnAddExercise.TabIndex = 5;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            // 
            // cbMuscleGroup
            // 
            this.cbMuscleGroup.FormattingEnabled = true;
            this.cbMuscleGroup.Location = new System.Drawing.Point(315, 182);
            this.cbMuscleGroup.Name = "cbMuscleGroup";
            this.cbMuscleGroup.Size = new System.Drawing.Size(142, 23);
            this.cbMuscleGroup.TabIndex = 6;
            // 
            // btnOpenUpdate
            // 
            this.btnOpenUpdate.Location = new System.Drawing.Point(522, 12);
            this.btnOpenUpdate.Name = "btnOpenUpdate";
            this.btnOpenUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnOpenUpdate.TabIndex = 7;
            this.btnOpenUpdate.Text = "Update Form";
            this.btnOpenUpdate.UseVisualStyleBackColor = true;
            // 
            // btnOpenWorkoutBuilder
            // 
            this.btnOpenWorkoutBuilder.Location = new System.Drawing.Point(651, 12);
            this.btnOpenWorkoutBuilder.Name = "btnOpenWorkoutBuilder";
            this.btnOpenWorkoutBuilder.Size = new System.Drawing.Size(107, 23);
            this.btnOpenWorkoutBuilder.TabIndex = 8;
            this.btnOpenWorkoutBuilder.Text = "Workout Builder ";
            this.btnOpenWorkoutBuilder.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenWorkoutBuilder);
            this.Controls.Add(this.btnOpenUpdate);
            this.Controls.Add(this.cbMuscleGroup);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.lblAddExercise);
            this.Controls.Add(this.txtAddExercise);
            this.Controls.Add(this.lblMuscleGroup);
            this.Controls.Add(this.btnMuscleGroup);
            this.Controls.Add(this.txtMuscleGroup);
            this.Name = "Add";
            this.Text = "Add to database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMuscleGroup;
        private Button btnMuscleGroup;
        private Label lblMuscleGroup;
        private TextBox txtAddExercise;
        private Label lblAddExercise;
        private Button btnAddExercise;
        private ComboBox cbMuscleGroup;
        private Button btnOpenUpdate;
        private Button btnOpenWorkoutBuilder;
    }
}