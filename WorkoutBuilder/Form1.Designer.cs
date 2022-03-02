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
            this.gbAddUpdateDelete = new System.Windows.Forms.GroupBox();
            this.cbUpdateDelete = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddMuscleOrExercise = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbAddUpdateDelete.SuspendLayout();
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
            this.tsmAddmuscleGroup.Size = new System.Drawing.Size(180, 22);
            this.tsmAddmuscleGroup.Text = "Add ";
            this.tsmAddmuscleGroup.Click += new System.EventHandler(this.tsmAddmuscleGroup_Click);
            // 
            // tsmUpdateMG
            // 
            this.tsmUpdateMG.Name = "tsmUpdateMG";
            this.tsmUpdateMG.Size = new System.Drawing.Size(180, 22);
            this.tsmUpdateMG.Text = "Update";
            this.tsmUpdateMG.Click += new System.EventHandler(this.tsmUpdateMG_Click);
            // 
            // tsmDeleteMG
            // 
            this.tsmDeleteMG.Name = "tsmDeleteMG";
            this.tsmDeleteMG.Size = new System.Drawing.Size(180, 22);
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
            // gbAddUpdateDelete
            // 
            this.gbAddUpdateDelete.Controls.Add(this.cbUpdateDelete);
            this.gbAddUpdateDelete.Controls.Add(this.label1);
            this.gbAddUpdateDelete.Controls.Add(this.txtAddMuscleOrExercise);
            this.gbAddUpdateDelete.Controls.Add(this.btnAddUpdate);
            this.gbAddUpdateDelete.Location = new System.Drawing.Point(42, 151);
            this.gbAddUpdateDelete.Name = "gbAddUpdateDelete";
            this.gbAddUpdateDelete.Size = new System.Drawing.Size(409, 240);
            this.gbAddUpdateDelete.TabIndex = 12;
            this.gbAddUpdateDelete.TabStop = false;
            this.gbAddUpdateDelete.Visible = false;
            // 
            // cbUpdateDelete
            // 
            this.cbUpdateDelete.FormattingEnabled = true;
            this.cbUpdateDelete.Location = new System.Drawing.Point(35, 93);
            this.cbUpdateDelete.Name = "cbUpdateDelete";
            this.cbUpdateDelete.Size = new System.Drawing.Size(211, 23);
            this.cbUpdateDelete.TabIndex = 4;
            this.cbUpdateDelete.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // txtAddMuscleOrExercise
            // 
            this.txtAddMuscleOrExercise.Location = new System.Drawing.Point(35, 73);
            this.txtAddMuscleOrExercise.Name = "txtAddMuscleOrExercise";
            this.txtAddMuscleOrExercise.Size = new System.Drawing.Size(211, 23);
            this.txtAddMuscleOrExercise.TabIndex = 2;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(185, 163);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(190, 71);
            this.btnAddUpdate.TabIndex = 1;
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAddUpdateDelete);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Add to database";
            this.Load += new System.EventHandler(this.Add_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAddUpdateDelete.ResumeLayout(false);
            this.gbAddUpdateDelete.PerformLayout();
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
        private GroupBox gbAddUpdateDelete;
        private TextBox txtAddMuscleOrExercise;
        private Button btnAddUpdate;
        private Label label1;
        private ComboBox cbUpdateDelete;
    }
}