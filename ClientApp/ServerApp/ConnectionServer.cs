using ServerApp;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    /// <summary>
    /// Класс для настройки подключения к серверу
    /// </summary>
    internal class ConnectionServer
    {
        int port;
        string address;
        TcpClient client;
        NetworkStream stream;
        MainFormClient form;


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="port">Порт</param>
        /// /// <param name="address">Адрес</param>
        public ConnectionServer(int port, string address)
        {
            this.port = port;
            this.address = address;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="port">Порт</param>
        public ConnectionServer(int port)
        {
            this.port = port;
            this.address = "127.0.0.1";
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="port">Порт</param>
        /// <param name="form">Главная форма</param>
        public ConnectionServer(int port, MainFormClient form)
        {
            this.port = port;
            this.address = "127.0.0.1";
            this.form = form;
        }

        /// <summary>
        /// Таск на выполнение запросов клиента и получения ответов от сервера
        /// </summary>
        /// <param name="query">Запрос</param>
        /// <returns></returns>
        public async Task<bool> ClientTask(string query)
        {
            string answer;
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    await client.ConnectAsync(address, port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8, leaveOpen: true))
                        {
                            await writer.WriteLineAsync(query);
                            await writer.FlushAsync();
                        }

                        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8, leaveOpen: true))
                        {
                            answer = await reader.ReadLineAsync();
                        }

                        if (!answer.Contains("Ошибка"))
                        {
                            RichRextBoxEditor.SetMessageTextFromServer(form.rtbDialog, query, answer);
                            return true;
                        }
                        else
                        {
                            RichRextBoxEditor.SetMessageTextFromServer(form.rtbDialog, query, answer);
                            await Task.Delay(1000); // Небольшая пауза перед повторной попыткой
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
