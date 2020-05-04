using System.IO;
using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;

namespace TelegramBotHSE
{
    public static class NapravleniyaNovgorod
    {
        /// <summary>
        /// Меню направлений в Нижнем Новгороде
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void NovgorodFaculteti(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Математика (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Прикладная математика и информатика (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Программная инженерия (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Экономика (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Управление бизнесом (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Бизнес-информатика (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Юриспруденция (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Филология (Новгород)")
                },
                new[]
                {
                    new KeyboardButton("Фундаментальная и прикладная лингвистика (Новгород)")
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
