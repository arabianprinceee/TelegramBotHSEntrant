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
    public static class NapravleniyaSPB
    {
        /// <summary>
        /// Основное меню по направлениям в Питере
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
                    new KeyboardButton("Прикладная математика и информатика (СПБ)")
                },
                new[]
                {
                    new KeyboardButton("Физика (СПБ)")
                },
                new[]
                {
                    new KeyboardButton("Экономика (СПБ)") 
                },
                new[]
                {
                    new KeyboardButton("Международный бизнес и менеджмент")
                },
                new[]
                {
                    new KeyboardButton("Логистика и управление цепями поставок")
                },
                new[]
                {
                    new KeyboardButton("Управление и аналитика в государственном секторе")
                },
                new[]
                {
                    new KeyboardButton("Социология и социальная информатика")
                },
                new[]
                {
                    new KeyboardButton("Юриспруденция (СПБ)")
                },
                new[]
                {
                    new KeyboardButton("Политология и мировая политика")
                },
                new[]
                {
                    new KeyboardButton("Филология (СПБ)")
                },
                new[]
                {
                    new KeyboardButton("История (СПБ)")
                },
                new[]
                {
                    new KeyboardButton("Дизайн (СПБ)")
                },
                new[]
                {
                    new KeyboardButton("Востоковедение (СПБ)")
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
