using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    static class StringAnalizer
    {
        /// <summary>
        /// Метод, который проверяет, являесят ли строка полиндромом*
        /// * - считает все символы (пробелы, знаки препинания)
        /// </summary>
        /// <param name="str">проверяемая строка</param>
        /// <returns></returns>
        public static bool IsStringPolindrome(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
