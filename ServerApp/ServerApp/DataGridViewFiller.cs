using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApp
{
    /// <summary>
    /// Класс для работы с datagridview
    /// </summary>
    static class DataGridViewQueriesFiller
    {
        /// <summary>
        /// Метод для заполнения datagridview
        /// </summary>
        /// <param name="form">Главная форма</param>
        /// <param name="dateTime">Время</param>
        /// <param name="query">Запрос серверу</param>
        /// <param name="answer">Ответ сервера</param>
        public static async void AddRowDataGridViewQueries(DataGridView dgvClientQueries, DateTime dateTime, string client, string query, string answer)
        {
            // Заполняем только в потоке, который создал dgv
            dgvClientQueries.Invoke((MethodInvoker)delegate {
                var index = dgvClientQueries.Rows.Add();
                dgvClientQueries.Rows[index].Cells["ClientAddress"].Value = client;
                dgvClientQueries.Rows[index].Cells["TimeOfQuery"].Value = dateTime;
                dgvClientQueries.Rows[index].Cells["Query"].Value = query;
                dgvClientQueries.Rows[index].Cells["Answer"].Value = answer;

                dgvClientQueries.ClearSelection();
                int rowsCount = dgvClientQueries.Rows.Count - 1;
                dgvClientQueries.Rows[rowsCount].Selected = true;
                dgvClientQueries.FirstDisplayedScrollingRowIndex = rowsCount;

                dgvClientQueries.Update();
            });

        }
    }
}
