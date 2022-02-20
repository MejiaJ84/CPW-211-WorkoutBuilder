namespace WorkoutBuilder
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMuscleGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddmuscleGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateMG = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteMG = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDeleteExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWorkoutBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.gbtest1 = new System.Windows.Forms.GroupBox();
            this.txttest1 = new System.Windows.Forms.TextBox();
            this.btntest1 = new System.Windows.Forms.Button();
            this.lbltest1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbtest1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMuscleGroup,
            this.tsmExercise,
            this.tsmWorkoutBuilder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tsmMuscleGroup
            // 
            this.tsmMuscleGroup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddmuscleGroup,
            this.tsmUpdateMG,
            this.tsmDeleteMG});
            this.tsmMuscleGroup.Name = "tsmMuscleGroup";
            this.tsmMuscleGroup.Size = new System.Drawing.Size(93, 20);
            this.tsmMuscleGroup.Text = "Muscle Group";
            // 
            // tsmAddmuscleGroup
            // 
            this.tsmAddmuscleGroup.Name = "tsmAddmuscleGroup";
            this.tsmAddmuscleGroup.Size = new System.Drawing.Size(181, 22);
            this.tsmAddmuscleGroup.Text = "Add ";
            this.tsmAddmuscleGroup.Click += new System.EventHandler(this.tsmAddmuscleGroup_Click);
            // 
            // tsmUpdateMG
            // 
            this.tsmUpdateMG.Name = "tsmUpdateMG";
            this.tsmUpdateMG.Size = new System.Drawing.Size(181, 22);
            this.tsmUpdateMG.Text = "Update";
            // 
            // tsmDeleteMG
            // 
            this.tsmDeleteMG.Name = "tsmDeleteMG";
            this.tsmDeleteMG.Size = new System.Drawing.Size(181, 22);
            this.tsmDeleteMG.Text = "Delete";
            // 
            // tsmExercise
            // 
            this.tsmExercise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddExercise,
            this.toolStripSeparator3,
            this.UpdateExercise,
            this.toolStripSeparator4,
            this.tsmDeleteExercise});
            this.tsmExercise.Name = "tsmExercise";
            this.tsmExercise.Size = new System.Drawing.Size(61, 20);
            this.tsmExercise.Text = "Exercise";
            // 
            // tsmAddExercise
            // 
            this.tsmAddExercise.Name = "tsmAddExercise";
            this.tsmAddExercise.Size = new System.Drawing.Size(112, 22);
            this.tsmAddExercise.Text = "Add";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(109, 6);
            // 
            // UpdateExercise
            // 
            this.UpdateExercise.Name = "UpdateExercise";
            this.UpdateExercise.Size = new System.Drawing.Size(112, 22);
            this.UpdateExercise.Text = "Update";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(109, 6);
            // 
            // tsmDeleteExercise
            // 
            this.tsmDeleteExercise.Name = "tsmDeleteExercise";
            this.tsmDeleteExercise.Size = new System.Drawing.Size(112, 22);
            this.tsmDeleteExercise.Text = "Delete";
            // 
            // tsmWorkoutBuilder
            // 
            this.tsmWorkoutBuilder.Name = "tsmWorkoutBuilder";
            this.tsmWorkoutBuilder.Size = new System.Drawing.Size(137, 20);
            this.tsmWorkoutBuilder.Text = "Open Workout Builder";
            // 
            // txtWelcome
            // 
            this.txtWelcome.Enabled = false;
            this.txtWelcome.Location = new System.Drawing.Point(176, 51);
            this.txtWelcome.Multiline = true;
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(344, 43);
            this.txtWelcome.TabIndex = 11;
            this.txtWelcome.Text = "Welcome to Workout Builder app version 1.00.alpha1\r\nPlease make you selection fro" +
    "m the menu above to get started.\r\n";
            this.txtWelcome.WordWrap = false;
            // 
            // gbtest1
            // 
            this.gbtest1.Controls.Add(this.txttest1);
            this.gbtest1.Controls.Add(this.btntest1);
            this.gbtest1.Controls.Add(this.lbltest1);
            this.gbtest1.Location = new System.Drawing.Point(42, 151);
            this.gbtest1.Name = "gbtest1";
            this.gbtest1.Size = new System.Drawing.Size(200, 100);
            this.gbtest1.TabIndex = 12;
            this.gbtest1.TabStop = false;
            this.gbtest1.Text = "Add";
            this.gbtest1.Visible = false;
            // 
            // txttest1
            // 
            this.txttest1.Location = new System.Drawing.Point(21, 66);
            this.txttest1.Name = "txttest1";
            this.txttest1.Size = new System.Drawing.Size(100, 23);
            this.txttest1.TabIndex = 2;
            this.txttest1.Text = "test1";
            // 
            // btntest1
            // 
            this.btntest1.Location = new System.Drawing.Point(102, 22);
            this.btntest1.Name = "btntest1";
            this.btntest1.Size = new System.Drawing.Size(75, 23);
            this.btntest1.TabIndex = 1;
            this.btntest1.Text = "test1";
            this.btntest1.UseVisualStyleBackColor = true;
            this.btntest1.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // lbltest1
            // 
            this.lbltest1.AutoSize = true;
            this.lbltest1.Location = new System.Drawing.Point(21, 19);
            this.lbltest1.Name = "lbltest1";
            this.lbltest1.Size = new System.Drawing.Size(29, 15);
            this.lbltest1.TabIndex = 0;
            this.lbltest1.Text = "Add";
            // 
            // Main
            // 
            this.AcceptButton = this.btntest1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbtest1);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Add to database";
            this.Load += new System.EventHandler(this.Add_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbtest1.ResumeLayout(false);
            this.gbtest1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmMuscleGroup;
        private ToolStripMenuItem tsmAddmuscleGroup;
        private ToolStripMenuItem tsmUpdateMG;
        private ToolStripMenuItem tsmDeleteMG;
        private ToolStripMenuItem tsmExercise;
        private ToolStripMenuItem tsmAddExercise;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem UpdateExercise;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem tsmDeleteExercise;
        private ToolStripMenuItem tsmWorkoutBuilder;
        private TextBox txtWelcome;
        private GroupBox gbtest1;
        private TextBox txttest1;
        private Button btntest1;
        private Label lbltest1;
    }
}