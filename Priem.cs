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
    public static class Priem
    {

        /// <summary>
        /// Метод, в котором разработано ОСНОВНОЕ меню пункта ПРИЁМНОЙ КОМИССИИ
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PriemnayaKomissiya(Telegram.Bot.Args.MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PriemnayaKomissiyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите интересующий Вас город или вернитесь в главное меню", replyMarkup: KeyBoard);
        }


        /// <summary>
        /// Метод с реализацией части раздела "приемная комиссия" по г.МОСКВА
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PriemMoscow(Telegram.Bot.Args.MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PriemMoscowSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужную информацию или вернитесь в главное меню:", replyMarkup: KeyBoard);
    }

        /// <summary>
        /// Метод, возвращающий информацию о работе приемной комиссии в Москве (адрес, телефон и тд)
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfoMoscow(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            await Client.SendTextMessageAsync(message.Chat.Id, "Адрес: Москва, ул. Мясницкая, д. 20\n" +
                    "\nТел.: (495) 771-32-42, (495) 916-88-44\n\nE-mail: abitur@hse.ru\n\nВРЕМЯ РАБОТЫ: \nПн. - пт. с 10:00 до 17:00\nСб., вс. — выходные дни" +
                    "\n\nОфициальный сайт – https://ba.hse.ru");
        }

        /// <summary>
        /// Метод с реализацией части раздела "приемная комиссия" по г.Санкт-Петербург
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PriemPeterburg(Telegram.Bot.Args.MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PriemPeterburgSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужную информацию или вернитесь в главное меню:", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Метод, возвращающий информацию о работе приемной комиссии в Санкт-Петербурге (адрес, телефон и тд)
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfoPiter(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            await Client.SendTextMessageAsync(message.Chat.Id, "Адрес: Санкт-Петербург, ул. Кантемировская, д. 3, к. 1, лит А, ауд. 239\n" +
                     "\nТел. : (812)644-62-12\n\nE-mail: abitur-spb@hse.ru\n\nВРЕМЯ РАБОТЫ: \nПн. - пт. с 10:00 до 17:00\nСб., вс. — выходные дни" +
                     "\n\nОфициальный сайт – https://spb.hse.ru/ba/");
        }


        /// <summary>
        /// Метод с реализацией части раздела "приемная комиссия" по г.Пермь
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PriemPerm(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PriemPermSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужную информацию или вернитесь в главное меню:", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Метод, возвращающий информацию о работе приемной комиссии в Перми (адрес, телефон и тд)
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfoPerm(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            await Client.SendTextMessageAsync(message.Chat.Id, "АДРЕС: Пермь, ул. Студенческая, 38, ауд. 107\n" +
                    "\nТел. : +7(342)-200-96-96\n\nE-mail: abitur.perm@hse.ru\n\nВРЕМЯ РАБОТЫ: \nПн. - пт. с 10:00 до 17:00\n❗️Перерыв с 12:00 до 12:30❗️\nСб., вс. — выходные дни" +
                    "\n\nОфициальный сайт – https://perm.hse.ru/bacalavr/");
        }

        /// <summary>
        /// Метод с реализацией части раздела "приемная комиссия" по г.Нижний Новгород
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PriemNovgorod(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PriemNovgorodSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужную информацию или вернитесь в главное меню:", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Метод, возвращающий информацию о работе приемной комиссии в Нижнем Новгороде (адрес, телефон и тд)
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfoNovgorod(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            await Client.SendTextMessageAsync(message.Chat.Id, "АДРЕС: Нижний Новгород, ул. Б.Печерская, 25/12\n" +
                    "\nТел. : (831)-416-97-77\n\nE-mail: pknn@hse.ru\n\nВРЕМЯ РАБОТЫ: \nПн. - пт. с 9:00 до 17:00\nСб., вс. — выходные дни" +
                    "\n\nОфициальный сайт – https://nnov.hse.ru/bacnn/");
        }

    }
}
