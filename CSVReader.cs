using System;
using System.Collections.Generic;
using System.IO;

namespace TelegramBotHSE
{
    public static class CSVReader
    {
        /// <summary>
        /// Метод, считывающий по строкам информацию из CSV файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>В результате работы возвращает массив строк</returns>
        public static List<string> ReadCSV(string path)
        {
            List<string> lines = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        lines.Add(sr.ReadLine().Replace(';', '⁣').Replace('!', '\n'));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " : Ошибка в обработке файла");
            }

            return lines;
        }
    }
}
