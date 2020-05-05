using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using System.Collections.Generic;
using System.Text.Json;

namespace TelegramBotHSE
{
    public static class FAQ
    {
        /// <summary>
        /// Основная клавиатура раздела FAQ
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void FAQKeyBoard(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("FAQKeyBoardSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Переход выполнен", replyMarkup: KeyBoard);
        }

        
    }
}
