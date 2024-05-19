using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace ServerApp
{
    internal class Server
    {
        int port;
        IPAddress address;
        private static TcpListener? server;
        byte n;
        // Статус сервера, по умолчанию не запущен. Разрешаем только чтение.
        public bool isStarted { get; } = false;

        /// <summary>
        /// Конструктор для создания сервера
        /// </summary>
        /// <param name="port">значение порта</param>
        /// <param name="address">значение адреса</param>
        /// <param name="n">максимальное количество обрабатываемых одновременно запросов</param>
        public Server(int port, IPAddress address, byte n)
        {
            this.port = port;
            this.address = address;
            this.n = n;
        }

        /// <summary>
        /// Конструктор для создания сервера без указания IP-адреса
        /// </summary>
        /// <param name="port">значение порта</param>
        /// <param name="n">максимальное количество обрабатываемых одновременно запросов</param>
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
        }

        /// <summary>
        /// Метод для прослушивания клиентов
        /// </summary>
        public async Task ListenClients()
        {
            if (server is null) 
            {
                return;
            }
            while (true)
            {
                
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
