using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static partial class StringExtension
    {
        private static char[] NewLineChars = new char[] { '\r', '\n' };

        /// <summary>
        /// Возвращает первую строку в многострочном тексте. Если передана пустая строка, возвращается String.Empty.
        /// Если передан null, возвращается null.
        /// </summary>
        /// <param name="source">Возможно многострочный текст</param>
        public static string FirstLine(this string source)
        {
            return (source == null) ? null : (EnumLines(source).FirstOrDefault() ?? string.Empty);
        }

        /// <summary>
        /// Проверка на то, что строка пустая или null
        /// </summary>
        /// <param name="source">строка, может быть null</param>
        /// <returns>true, если строка пустая</returns>
        public static bool IsEmpty(this string source)
        {
            return string.IsNullOrEmpty(source);
        }

        /// <summary>
        /// Проверка на равенство строк без учета регистра
        /// </summary>
        /// <param name="source"></param>
        /// <param name="checkString"></param>
        /// <returns>True если равны</returns>
        public static bool SameAs(this string source, string checkString)
        {
            return (string.IsNullOrEmpty(source) && string.IsNullOrEmpty(checkString)) ||
                string.Equals(source, checkString, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Приводит все символы конца строки к стандарту Environment.NewLine
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NormalizeCrLf(this string str)
        {
            return NormalizeCrLf(str, Environment.NewLine);
        }

        /// <summary>
        /// Заменяет все символы конца строки на указанный разделитель
        /// </summary>
        /// <param name="str"></param>
        /// <param name="lineSeparator">разделитель строк</param>
        /// <returns></returns>
        public static string NormalizeCrLf(this string str, string lineSeparator)
        {
            if (str == null)
                return null;
            int count = 0;
            StringBuilder builder = null;
            foreach (string line in EnumLines(str))
            {
                if (count == 0)
                {
                    // оптимизация на случай единственной строки
                    if (ReferenceEquals(line, str))
                        return str;
                    builder = new StringBuilder();
                }
                else
                    builder.Append(lineSeparator);
                builder.Append(line);
                count++;
            }
            if (count == 0)
                return string.Empty;
            return builder.ToString();
        }

        /// <summary>
        /// Перебирает все строки в многострочном тексте. Если текст заканчивается символом конца строки, то последняя
        /// строка возвращается как String.Empty. Если текст начинается с символа конца строки, то первая строка
        /// возвращается как String.Empty. Если текст - пустая строка, возвращается пустое множество. Если входной 
        /// параметр равен null, дает ошибку.
        /// </summary>
        /// <param name="str"></param>
        public static IEnumerable<string> EnumLines(this string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));

            int len = str.Length;
            if (len == 0)
                yield break;
            int index = 0;
            while (true)
            {
                if (index == len)
                {
                    yield return string.Empty;
                    break;
                }
                int pos = str.IndexOfAny(NewLineChars, index);
                if (pos == -1)
                {
                    // для оптимизации возвращаем саму str, если возможно
                    yield return (index == 0) ? str : str.Substring(index);
                    break;
                }
                yield return str.Substring(index, pos - index);
                // eating \r\n sequence
                if (str[pos] == '\r' && pos + 1 < len && str[pos + 1] == '\n')
                    pos++;
                index = pos + 1;
            }
        }

        /// <summary>
        /// Форматирует строку как строковую константу для передачи в SQL. Строка принимает вид <c>"N'string chars'"</c>. 
        /// Значение <c>null</c> превращается в строку <c>"null"</c>.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string SqlQuotedStr(this string str)
        {
            return (str == null) ? "null" : "N'" + str.Replace("'", "''") + "'";
        }

    }
}
