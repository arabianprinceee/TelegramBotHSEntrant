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
    public static class HelpfulLinks
    {
        /// <summary>
        /// Метод, в котором разработано меню с кнопками, содержащими в себе некоторые ПОЛЕЗНЫЕ ССЫЛКИ
        /// </summary>
        /// <param name="e"></param>
        public static async void ShowHelpfulLinks(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            var menuKeyboard = new InlineKeyboardMarkup(new[]
            {

                new[]
                {
                    InlineKeyboardButton.WithUrl("Сайт Московского кампуса", "https://www.hse.ru"),
                    InlineKeyboardButton.WithUrl("Сайт Питерского кампуса", "https://spb.hse.ru")
                },
                new[]
                {
                    InlineKeyboardButton.WithUrl("Сайт Нижегородского кампуса", "https://nnov.hse.ru"),
                    InlineKeyboardButton.WithUrl("Сайт Пермского кампуса", "https://perm.hse.ru")
                },
                new[]
                {
                    InlineKeyboardButton.WithUrl("Группа для абитуриентов в VK", "https://vk.com/ba_hse")
                },
                new[]
                {
                    InlineKeyboardButton.WithUrl("Вышка в Facebook", "https://www.facebook.com/hse.ru"),
                    InlineKeyboardButton.WithUrl("Вышка в Instagram", "https://www.instagram.com/hse_ru/"),
                    InlineKeyboardButton.WithUrl("Вышка в VK", "https://vk.com/hse_university")
                }
            });

            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужную сcылку:", replyMarkup: menuKeyboard);
            await Client.SendStickerAsync(message.Chat.Id, "CAACAgIAAxkBAAEOx1deblVYpNjC3stEpnKftOyRiZoO3gACVgEAAk-cEwJ5KHBO9mHQYBgE");
        }
    }
}
