using System.Security;
using System.Windows.Forms;
using System.IO;
using ClientApp;
using System.Net.Sockets;

namespace ServerApp
{
    public partial class MainFormClient : Form
    {
        string filePath = "";

        public MainFormClient()
        {
            InitializeComponent();
        }


        private void choseFilePathBtn_Click(object sender, EventArgs e)
        {
            GetFilePath();
        }

        /// <summary>
        /// Метод для получения пути к папке
        /// </summary>
        private void GetFilePath()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                lblFilePathValue.ForeColor = Color.Black;
                lblFilePathValue.Text = folderBrowserDialog.SelectedPath;
                filePath = folderBrowserDialog.SelectedPath;
                startBtn.Visible = true;
                clearBtn.Visible = true;
            }
        }

        /// <summary>
        /// Отправка/получение информации серверу/от сервера
        /// </summary>
        private async void SendQueriesToServer()
        {
            string[] files = Directory.GetFiles(filePath, "*.txt");
            ConnectionServer connectionServer;

            try
            {
                connectionServer = new ConnectionServer(8888, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            foreach (string file in files)
            {
                StreamReader reader = new StreamReader(file);
                string query = reader.ReadToEnd();
                reader.Close();

                _ = Task.Run(async () =>
                {
                    bool success = false;
                    while (!success)
                    {
                        success = await connectionServer.ClientTask(query);
                    }
                });

            }
        }

        /// <summary>
        /// Метод для начала отправки запросов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBtn_Click(object sender, EventArgs e)
        {
            SendQueriesToServer();
        }

        /// <summary>
        /// Метод для очистки диалога
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            rtbDialog.Clear();
        }
    }
}
