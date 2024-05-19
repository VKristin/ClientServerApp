using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    /// <summary>
    /// Статический класс для хранения состояний сервера
    /// </summary>
    public static class ServerStatus
    {
        public static string Started = "Запущен";

        public static string Stoped = "Не запущен";
    }
}
