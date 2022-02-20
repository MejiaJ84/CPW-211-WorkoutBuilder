namespace WorkoutBuilder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        private void btntest1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ive been clicked");
        }

        private void tsmAddmuscleGroup_Click(object sender, EventArgs e)
        {
            gbtest1.Visible = true;
            makeInvisible(gbtest1);
            
        }
        
        private static void makeInvisible(GroupBox gbVanish)
        {
            gbVanish.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //menuStrip1.Items
        }
    }
}