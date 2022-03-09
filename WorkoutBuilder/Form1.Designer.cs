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
            this.tsmUpdateExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteExercise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWorkoutBuilder = new System.Windows.Forms.ToolStripMenuItem();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.gbAddUpdateDelete = new System.Windows.Forms.GroupBox();
            this.cbUpdateDeleteExercise = new System.Windows.Forms.ComboBox();
            this.lblExerciseDescription = new System.Windows.Forms.Label();
            this.rtxtExerciseDescription = new System.Windows.Forms.RichTextBox();
            this.cbUpdateDelete = new System.Windows.Forms.ComboBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtAddMuscleOrExercise = new System.Windows.Forms.TextBox();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.gbAddUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMuscleGroup,
            this.tsmExercise,
            this.tsmWorkoutBuilder});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 30);
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
            this.tsmMuscleGroup.Size = new System.Drawing.Size(119, 24);
            this.tsmMuscleGroup.Text = "Muscle Group";
            // 
            // tsmAddmuscleGroup
            // 
            this.tsmAddmuscleGroup.Name = "tsmAddmuscleGroup";

            this.tsmAddmuscleGroup.Size = new System.Drawing.Size(112, 22);

            this.tsmAddmuscleGroup.Text = "Add ";
            this.tsmAddmuscleGroup.Click += new System.EventHandler(this.tsmAddmuscleGroup_Click);
            // 
            // tsmUpdateMG
            // 
            this.tsmUpdateMG.Name = "tsmUpdateMG";

            this.tsmUpdateMG.Size = new System.Drawing.Size(112, 22);

            this.tsmUpdateMG.Text = "Update";
            this.tsmUpdateMG.Click += new System.EventHandler(this.tsmUpdateMG_Click);
            // 
            // tsmDeleteMG
            // 
            this.tsmDeleteMG.Name = "tsmDeleteMG";

            this.tsmDeleteMG.Size = new System.Drawing.Size(112, 22);

            this.tsmDeleteMG.Text = "Delete";
            this.tsmDeleteMG.Click += new System.EventHandler(this.tsmDeleteMG_Click);
            // 
            // tsmExercise
            // 
            this.tsmExercise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAddExercise,
            this.tsmUpdateExercise,
            this.tsmDeleteExercise});
            this.tsmExercise.Name = "tsmExercise";
            this.tsmExercise.Size = new System.Drawing.Size(76, 24);
            this.tsmExercise.Text = "Exercise";
            // 
            // tsmAddExercise
            // 
            this.tsmAddExercise.Name = "tsmAddExercise";
 
            this.tsmAddExercise.Size = new System.Drawing.Size(180, 22);

            this.tsmAddExercise.Text = "Add";
            this.tsmAddExercise.Click += new System.EventHandler(this.tsmAddExercise_Click);
            // 
            // tsmUpdateExercise
            // 

            this.tsmUpdateExercise.Name = "tsmUpdateExercise";
            this.tsmUpdateExercise.Size = new System.Drawing.Size(180, 22);
            this.tsmUpdateExercise.Text = "Update";
            this.tsmUpdateExercise.Click += new System.EventHandler(this.tsmUpdateExercise_Click);

            // 
            // tsmDeleteExercise
            // 
            this.tsmDeleteExercise.Name = "tsmDeleteExercise";

            this.tsmDeleteExercise.Size = new System.Drawing.Size(180, 22);

            this.tsmDeleteExercise.Text = "Delete";
            this.tsmDeleteExercise.Click += new System.EventHandler(this.tsmDeleteExercise_Click);
            // 
            // tsmWorkoutBuilder
            // 
            this.tsmWorkoutBuilder.Name = "tsmWorkoutBuilder";
            this.tsmWorkoutBuilder.Size = new System.Drawing.Size(178, 24);
            this.tsmWorkoutBuilder.Text = "Open Workout Builder";
            this.tsmWorkoutBuilder.Click += new System.EventHandler(this.tsmWorkoutBuilder_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.Enabled = false;
            this.txtWelcome.Location = new System.Drawing.Point(226, 68);
            this.txtWelcome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWelcome.Multiline = true;
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(441, 56);
            this.txtWelcome.TabIndex = 11;
            this.txtWelcome.Text = "Welcome to Workout Builder app version 1.00.alpha1\r\nPlease make you selection fro" +
    "m the menu above to get started.\r\n";
            this.txtWelcome.WordWrap = false;
            // 
            // gbAddUpdateDelete
            // 
            this.gbAddUpdateDelete.Controls.Add(this.cbUpdateDeleteExercise);
            this.gbAddUpdateDelete.Controls.Add(this.lblExerciseDescription);
            this.gbAddUpdateDelete.Controls.Add(this.rtxtExerciseDescription);
            this.gbAddUpdateDelete.Controls.Add(this.cbUpdateDelete);
            this.gbAddUpdateDelete.Controls.Add(this.lblInstructions);
            this.gbAddUpdateDelete.Controls.Add(this.txtAddMuscleOrExercise);
            this.gbAddUpdateDelete.Controls.Add(this.btnAddUpdate);

            this.gbAddUpdateDelete.Location = new System.Drawing.Point(37, 151);
            this.gbAddUpdateDelete.Name = "gbAddUpdateDelete";
            this.gbAddUpdateDelete.Size = new System.Drawing.Size(519, 240);

            this.gbAddUpdateDelete.TabIndex = 12;
            this.gbAddUpdateDelete.TabStop = false;
            this.gbAddUpdateDelete.Visible = false;
            // 
            // cbUpdateDeleteExercise
            // 
            this.cbUpdateDeleteExercise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateDeleteExercise.FormattingEnabled = true;
            this.cbUpdateDeleteExercise.Location = new System.Drawing.Point(6, 66);
            this.cbUpdateDeleteExercise.MaxDropDownItems = 20;
            this.cbUpdateDeleteExercise.Name = "cbUpdateDeleteExercise";
            this.cbUpdateDeleteExercise.Size = new System.Drawing.Size(211, 23);
            this.cbUpdateDeleteExercise.TabIndex = 7;
            this.cbUpdateDeleteExercise.Visible = false;
            this.cbUpdateDeleteExercise.SelectedIndexChanged += new System.EventHandler(this.cbUpdateDeleteExercise_SelectedIndexChanged);
            // 
            // lblExerciseDescription
            // 
            this.lblExerciseDescription.AutoSize = true;
            this.lblExerciseDescription.Location = new System.Drawing.Point(6, 118);
            this.lblExerciseDescription.Name = "lblExerciseDescription";
            this.lblExerciseDescription.Size = new System.Drawing.Size(144, 15);
            this.lblExerciseDescription.TabIndex = 6;
            this.lblExerciseDescription.Text = "Enter exercise description.";
            this.lblExerciseDescription.Visible = false;
            // 
            // rtxtExerciseDescription
            // 
            this.rtxtExerciseDescription.Location = new System.Drawing.Point(6, 136);
            this.rtxtExerciseDescription.Name = "rtxtExerciseDescription";
            this.rtxtExerciseDescription.Size = new System.Drawing.Size(211, 98);
            this.rtxtExerciseDescription.TabIndex = 5;
            this.rtxtExerciseDescription.Text = "";
            this.rtxtExerciseDescription.Visible = false;
            // 
            // cbUpdateDelete
            // 
            this.cbUpdateDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdateDelete.FormattingEnabled = true;

            this.cbUpdateDelete.Location = new System.Drawing.Point(6, 92);
            this.cbUpdateDelete.MaxDropDownItems = 20;

            this.cbUpdateDelete.Name = "cbUpdateDelete";
            this.cbUpdateDelete.Size = new System.Drawing.Size(270, 28);
            this.cbUpdateDelete.TabIndex = 4;
            this.cbUpdateDelete.Visible = false;
            // 
            // lblInstructions
            // 

            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(69, 19);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(38, 15);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "label1\r\n";
            // 
            // txtAddMuscleOrExercise
            // 
            this.txtAddMuscleOrExercise.Location = new System.Drawing.Point(6, 37);

            this.txtAddMuscleOrExercise.Name = "txtAddMuscleOrExercise";
            this.txtAddMuscleOrExercise.Size = new System.Drawing.Size(270, 27);
            this.txtAddMuscleOrExercise.TabIndex = 2;
            // 
            // btnAddUpdate
            // 

            this.btnAddUpdate.Location = new System.Drawing.Point(241, 163);

            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(244, 95);
            this.btnAddUpdate.TabIndex = 1;
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnAddUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.gbAddUpdateDelete);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private ToolStripMenuItem tsmUpdateExercise;
        private ToolStripMenuItem tsmDeleteExercise;
        private ToolStripMenuItem tsmWorkoutBuilder;
        private TextBox txtWelcome;
        private GroupBox gbAddUpdateDelete;
        private TextBox txtAddMuscleOrExercise;
        private Button btnAddUpdate;
        private Label lblInstructions;
        private ComboBox cbUpdateDelete;
        private RichTextBox rtxtExerciseDescription;
        private Label lblExerciseDescription;
        private ComboBox cbUpdateDeleteExercise;
    }
}