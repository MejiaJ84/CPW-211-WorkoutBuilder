namespace WorkoutBuilder
{
    partial class Form1
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
            this.btnMuscleGroup.Size = new System.Drawing.Size(106, 23);
            this.btnMuscleGroup.TabIndex = 1;
            this.btnMuscleGroup.Text = "Add to database";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMuscleGroup);
            this.Controls.Add(this.btnMuscleGroup);
            this.Controls.Add(this.txtMuscleGroup);
            this.Name = "Form1";
            this.Text = "Add to database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMuscleGroup;
        private Button btnMuscleGroup;
        private Label lblMuscleGroup;
    }
}