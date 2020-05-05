using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Helpers;
using Telegram.Bot.Requests;
using System.Collections.Generic;

namespace TelegramBotHSE
{
    public static class HelpingFunctions
    {
        /// <summary>
        /// Метод, реализующий отправку документов пользователю
        /// </summary>
        /// <param name="path"></param>
        /// <param name="e"></param>
        public static async void SendDocument(string path, MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            try
            {
                using (Stream stream = System.IO.File.OpenRead(path))
                {
                    await Client.SendDocumentAsync(message.Chat.Id, new InputOnlineFile(stream, path));
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Проблемы с файлом: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        /// <summary>
        /// Метод, записывающий заданный текст в заданный файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="textToWrite">Текст для записи</param>
        public static void WriteToTextFile(string path, string textToWrite)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(textToWrite);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Проблемы с файлом: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        /// <summary>
        /// Метод, возвращающий содержимое текстового файла в виде строки
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Содержимое текстового файла</returns>
        public static string ReturnTextFromFile(string path)
        {
            string text = "";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    text = sr.ReadToEnd();
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Проблемы с файлом: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return text;
        }


        /// <summary>
        /// Метод, отправляющий пользователю текст заданного текстового файла
        /// </summary>
        /// <param name="path"></param>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SendTextFromFile(string path, MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string text = "";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        text += sr.ReadLine();
                    }
                }

                await Client.SendTextMessageAsync(message.Chat.Id, text.Replace('n', '\n'));
            }
            catch (IOException)
            {
                Console.WriteLine($"Проблемы с файлом: {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
