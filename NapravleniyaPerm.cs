using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

namespace TelegramBotHSE
{

    public static class NapravleniyaPerm
    {
        /// <summary>
        /// Меню факультетов в Перми
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SPBFaculteti(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Программная инженерия (Пермь)")
                },
                new[]
                {
                    new KeyboardButton("Экономика (Пермь)")
                },
                new[]
                {
                    new KeyboardButton("Управление бизнесом (Пермь)")
                },
                new[]
                {
                    new KeyboardButton("Бизнес-информатика (Пермь)")
                },
                new[]
                {
                    new KeyboardButton("Юриспруденция (Пермь)")
                },
                new[]
                {
                    new KeyboardButton("История (Пермь)")
                },
                new[]
                {
                    new KeyboardButton("К выбору города")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Ниже представлены все доступные направления:", replyMarkup: replyKeyBoard);
        }
    }
}
