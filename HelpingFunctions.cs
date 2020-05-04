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
        public static async void SendDocument(string path, Telegram.Bot.Args.MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            using (Stream stream = System.IO.File.OpenRead(path))
            {
                await Client.SendDocumentAsync(
                /* chatId: */ message.Chat.Id,
                /* document: */ new InputOnlineFile( /* content: */ stream, /* fileName: */ path)
                );
            }

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " : Ошибка в обработке файла");
                Environment.Exit(0);
            }
        }
    }
}
