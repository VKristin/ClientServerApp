namespace ServerApp
{
    public partial class MainFormServer : Form
    {
        Server server;
        public MainFormServer()
        {
            InitializeComponent();
        }

        private void MainFormServer_Load(object sender, EventArgs e)
        {

        }

        async private void startServerTsm_Click(object sender, EventArgs e)
        {
            SetMaxNumQueries setMaxNumQueries = new SetMaxNumQueries();
            DialogResult dialogResult = setMaxNumQueries.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                byte n = setMaxNumQueries.n;
                server = new Server(8888, n); 
                try
                {
                    server.StartServer();
                    SetStartedServerDesigne(n);
                    await server.ListenClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }

        }

        private void SetStartedServerDesigne(int n)
        {
            lblMaxNumQueriesValue.Text = n.ToString();
            lblServerStatusValue.ForeColor = Color.Green;
            lblServerStatusValue.Text = ServerStatus.Started;
            stopServerTsm.Visible = true;
            startServerTsm.Visible = false;
            lblMaxNumQueries.Visible = true;
            lblMaxNumQueriesValue.Visible = true;
        }

        private void SetStoppedServerDesigne()
        {
            lblServerStatusValue.Text = ServerStatus.Stoped;
            lblServerStatusValue.ForeColor = Color.Red;
            stopServerTsm.Visible = false;
            startServerTsm.Visible = true;
            lblMaxNumQueries.Visible = false;
            lblMaxNumQueriesValue.Visible = false;
        }

        private void stopServerTsm_Click(object sender, EventArgs e)
        {
            try
            {
                SetStoppedServerDesigne();
                server.StopServer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
