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
        int address;
        // Статус сервера, по умолчанию не запущен. Разрешаем только чтение.
        public bool isStarted { get; } = false;

        /// <summary>
        /// Конструктор для создания сервера
        /// </summary>
        /// <param name="port">значение порта</param>
        /// <param name="address">значение адреса</param>
        public Server(int port, int address)
        {
            this.port = port;
            this.address = address;
        }

    }
}
