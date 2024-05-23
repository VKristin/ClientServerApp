using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    /// <summary>
    /// Статический класс для работы с RichTextBox
    /// </summary>
    internal static class RichRextBoxEditor
    {
        /// <summary>
        /// Метод для вывода сообщений пользователя/сервера
        /// </summary>
        /// <param name="rtbDialog">RichTextBox на котором необходимо произвести изменения</param>
        /// <param name="query">Запрос для вывода</param>
        /// <param name="answer">Ответ для вывода</param>
        public static void SetMessageTextFromServer(RichTextBox rtbDialog, string query, string answer)
        {
            if (rtbDialog.InvokeRequired)
            {
                rtbDialog.Invoke((MethodInvoker)delegate {
                    rtbDialog.AppendText($"----------------------------------------------------------------------\n\n");
                    rtbDialog.AppendText($"Запрос: \n {query} \n\n");
                    rtbDialog.AppendText($"Ответ от сервера: \n {answer}\n\n");
                    rtbDialog.SelectionStart = rtbDialog.Text.Length;
                    rtbDialog.ScrollToCaret();
                    rtbDialog.Parent.Update();
                });
            }
            else
            {
                rtbDialog.AppendText($"----------------------------------------------------------------------\n\n");
                rtbDialog.AppendText($"Запрос: \n {query} \n\n");
                rtbDialog.AppendText($"Ответ от сервера: \n {answer}\n\n");
                rtbDialog.SelectionStart = rtbDialog.Text.Length;
                rtbDialog.ScrollToCaret();
                rtbDialog.Parent.Update();
            }
        }
    }
}
