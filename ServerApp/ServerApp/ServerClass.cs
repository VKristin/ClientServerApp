using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerApp
{
    /// <summary>
    /// Класс для работы с сервером
    /// </summary>
    internal class Server
    {
        int port;
        IPAddress address;
        private static TcpListener? server;
        byte n;
        private static SemaphoreSlim semaphore;

        MainFormServer form; // Для работы с компонентами на главной форме

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="port">Порт</param>
        /// <param name="address">Адрес</param>
        /// <param name="n">Количество одновременно обрабатываемых запросов</param>
        public Server(int port, IPAddress address, byte n)
        {
            this.port = port;
            this.address = address;
            this.n = n;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="port">Порт</param>
        /// <param name="n">Количество одновременно обрабатываемых запросов</param>
        /// <param name="form">Главная форма</param>
        public Server(int port, byte n, MainFormServer form)
        {
            this.port = port;
            this.n = n;
            this.address = IPAddress.Any;
            this.form = form;
        }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="port">Порт</param>
        /// <param name="n">Количество одновременно обрабатываемых запросов</param>
        public Server(int port, byte n)
        {
            this.port = port;
            this.address = IPAddress.Any;
            this.n = n;
        }

        /// <summary>
        /// Метод для запуска сервера
        /// </summary>
        public void StartServer()
        {
            server = new TcpListener(address, port);
            server.Start();
            semaphore = new SemaphoreSlim(n, n);
        }

        /// <summary>
        /// Метод для прослушивания клиентов
        /// </summary>
        /// <returns></returns>
        public async Task ListenClients()
        {
            if (server is null)
            {
                return;
            }

            while (true)
            {
                TcpClient client = await server.AcceptTcpClientAsync();
                _ = Task.Run(async () => await HandleClient(client));
            }
        }

        /// <summary>
        /// Метод обработки запроса пользователя. Если сервер может обработать запрос - обрабатывает, в ином случае - отправляет ошибку пользователю.
        /// </summary>
        /// <param name="client">Клиент, чьи запросы обрабатываются</param>
        /// <returns></returns>
        async Task HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);

            try
            {
                string query = await reader.ReadLineAsync();
                // Ensure the query is not null before processing
                if (query != null)
                {
                    query = string.Join("", query.Where(c => char.IsLetter(c)));

                    if (await semaphore.WaitAsync(0))
                    {
                        try
                        {
                            await ProcessRequest(query, stream, client);
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }
                    else
                    {
                        await ReturnErrorToUser(client);
                    }
                }
            }
            finally
            {
                if (client.Client != null)
                {
                    Console.WriteLine($"Client disconnected: {client.Client.RemoteEndPoint}");
                }
                client.Close();
            }
        }


        /// <summary>
        /// Метод обработки запроса
        /// </summary>
        /// <param name="query">запрос, которых необходимо обработать</param>
        /// <param name="stream">поток</param>
        /// <returns></returns>
        async Task ProcessRequest(string query, NetworkStream stream, TcpClient client)
        {
            string answer = StringAnalizer.IsStringPolindrome(query) ?
                            AnswerTextStaticClass.StringIsPolindrome :
                            AnswerTextStaticClass.StringIsNotPolindrome;

            Console.WriteLine($"query = {query}");
            Console.WriteLine($"answer = {answer}");

            DataGridViewQueriesFiller.AddRowDataGridViewQueries(form.dgvClientQueries,  DateTime.Now, client.Client.RemoteEndPoint.ToString(), query, answer);

            await Task.Delay(1000);

            using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8, leaveOpen: true))
            {
                await writer.WriteLineAsync(answer);
                await writer.FlushAsync();
            }
        }

        /// <summary>
        /// Метод отправки ошибки пользователю в случае, если уже обрабатывается максимальное количество запросов
        /// </summary>
        /// <param name="client">Клиент</param>
        /// <returns></returns>
        async private Task ReturnErrorToUser(TcpClient client)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(client.GetStream(), Encoding.UTF8, leaveOpen: true))
                {
                    string error = "Ошибка: Превышено максимальное количество одновременных запросов";
                    await writer.WriteLineAsync(error);
                    await writer.FlushAsync();

                    if (client.Client != null)
                    {
                        Console.WriteLine($"client = {client.Client.RemoteEndPoint}");
                    }
                    Console.WriteLine($"error = {error}");
                    DataGridViewQueriesFiller.AddRowDataGridViewQueries(form.dgvClientQueries, DateTime.Now, client.Client.RemoteEndPoint.ToString(), "Ошибка", error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при отправке сообщения об ошибке клиенту: {ex.Message}");
            }
        }

        /// <summary>
        /// Метод для остановки сервера
        /// </summary>
        public void StopServer()
        {
            if (server != null)
            {
                server.Stop();
            }
        }
    }
}
