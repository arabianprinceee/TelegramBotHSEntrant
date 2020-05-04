using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using System.Text.Json;

namespace TelegramBotHSE
{
    public static class Olympiads
    {
        /// <summary>
        /// Метод, использующийся в разделе олимпиад для отправки файла с перечнем
        /// </summary>
        /// <param name="path"></param>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SendOlymps(string path, MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            await Client.SendTextMessageAsync(message.Chat.Id, "Ниже появится PDF файл с перечнем:");
            HelpingFunctions.SendDocument(path, e, Client);
        }

        // <summary>
        /// Метод, реализующий функционал раздела с ОЛИМПИАДАМИ
        /// </summary>
        /// <param name="e"></param>
        public static async void OlympiadsMenu(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("OlympiadsMenuSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите интересующий Вас город или вернитесь в главное меню", replyMarkup: KeyBoard);
        }

    }
}
