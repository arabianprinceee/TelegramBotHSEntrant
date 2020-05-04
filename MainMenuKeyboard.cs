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

            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Направления подготовки")
                },
                new[]
                {
                    new KeyboardButton("Скидки на обучение"),
                    new KeyboardButton("Поступление по олимпиадам")
                },
                new[]
                {
                    new KeyboardButton("Приёмная комиссия"),
                    new KeyboardButton("Полезные ссылки")
                },
                new[]
                {
                    new KeyboardButton("Часто задаваемые вопросы"),
                    new KeyboardButton("Не нашли ответ на вопрос?")
                }
            });

            await Client.SendTextMessageAsync(message.Chat.Id, "Переход выполнен", replyMarkup: replyKeyBoard);
        }
    }
}
