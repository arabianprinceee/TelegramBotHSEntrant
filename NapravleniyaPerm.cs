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

    public static class NapravleniyaPerm
    {
        /// <summary>
        /// Меню факультетов в Перми
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PermFaculteti(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PermFacultetiSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Ниже представлены все доступные направления:", replyMarkup: KeyBoard);
        }
    }
}
