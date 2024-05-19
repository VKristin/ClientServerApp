namespace ServerApp
{
    public partial class MainFormServer : Form
    {
        public MainFormServer()
        {
            InitializeComponent();
        }

        private void MainFormServer_Load(object sender, EventArgs e)
        {

        }

        private void startServerTsm_Click(object sender, EventArgs e)
        {
            SetMaxNumQueries setMaxNumQueries = new SetMaxNumQueries();
            DialogResult dialogResult = setMaxNumQueries.ShowDialog();
        }
    }
}
