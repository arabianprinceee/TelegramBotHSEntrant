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
using System.Text.Json;

namespace TelegramBotHSE
{
    public static class MainMenuKeyboard
    {
        /// <summary>
        /// Метод, содержащий основную виртуальную клавиатуру, которая вызывается командой /KEYBOARD
        /// </summary>
        /// <param name="e"> Параметр клиента </param>
        public static async void MainKeyBoard(Telegram.Bot.Args.MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("MainKeyBoardSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Переход выполнен", replyMarkup: KeyBoard);
        }
    }
}
