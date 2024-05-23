namespace ServerApp
{
    public partial class MainFormServer : Form
    {
        Server server;
        public MainFormServer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ћетод дл€ запуска сервера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void startServerTsm_Click(object sender, EventArgs e)
        {
            SetMaxNumQueries setMaxNumQueries = new SetMaxNumQueries();
            DialogResult dialogResult = setMaxNumQueries.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                byte n = setMaxNumQueries.n;
                server = new Server(8888, n, this);
                try
                {
                    server.StartServer();
                    SetStartedServerDesigne(n);
                    await server.ListenClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    //return;
                }
            }

        }

        /// <summary>
        /// ”становка свойств, которые характерны запущенному серверу
        /// </summary>
        /// <param name="n"> оличество одновременно обробатываемых запросов</param>
        private void SetStartedServerDesigne(int n)
        {
            lblMaxNumQueriesValue.Text = n.ToString();
            lblServerStatusValue.ForeColor = Color.Green;
            lblServerStatusValue.Text = ServerStatus.Started;
            stopServerTsm.Visible = true;
            startServerTsm.Visible = false;
            lblMaxNumQueries.Visible = true;
            lblMaxNumQueriesValue.Visible = true;
            clearLogsTsm.Visible = true;
        }

        /// <summary>
        /// ”становка свойств, которые характерны незапущенному серверу
        /// </summary>
        private void SetStoppedServerDesigne()
        {
            lblServerStatusValue.Text = ServerStatus.Stoped;
            lblServerStatusValue.ForeColor = Color.Red;
            stopServerTsm.Visible = false;
            startServerTsm.Visible = true;
            lblMaxNumQueries.Visible = false;
            lblMaxNumQueriesValue.Visible = false;
            clearLogsTsm.Visible = false;
        }

        /// <summary>
        /// ћетод остановки сервера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// ћетод дл€ очистки логов в консоли и на dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearLogsTsm_Click(object sender, EventArgs e)
        {
            dgvClientQueries.Rows.Clear();
            Console.Clear();
        }
    }
}
