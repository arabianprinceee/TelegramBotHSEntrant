using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using System.Threading;


namespace TelegramBotHSE
{
    public static class Sales
    {
        /// <summary>
        /// Метод, содержащий в себе основную виртуальную клавиатуру раздела скидок
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SalesMainMKeyboard(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("По результатам ЕГЭ"),
                    new KeyboardButton("По результатам олимпиад")
                },
                new[]
                {
                    new KeyboardButton("Для выпускников лицея ВШЭ")
                },
                new[]
                {
                    new KeyboardButton("Для выпускников ФДП"),
                    new KeyboardButton("Скидки по иным основаниям")
                },
                new[]
                {
                    new KeyboardButton("Вернуться в главное меню")
                }
            });

            await Client.SendTextMessageAsync(message.Chat.Id, "Выберете основание для получения скидки на обучение", replyMarkup: replyKeyBoard);
        }


        /// <summary>
        /// Клавиатура выбора города в разделе о скидках при поступлении по ЕГЭ
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SalesEGE(MessageEventArgs e, TelegramBotClient Client) 
        {
            var message = e.Message;

            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("гор. Москва"),
                    new KeyboardButton("гор. Санкт-Петербург")
                },
                new[]
                {
                    new KeyboardButton("гор. Нижний Новгород"),
                    new KeyboardButton("гор. Пермь")
                },
                new[]
                {
                    new KeyboardButton("Назад"),
                    new KeyboardButton("Вернуться в главное меню")
                }
            });

            await Client.SendTextMessageAsync(message.Chat.Id, "Выберете город", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Вывод ПДФ файла для нужного города со скидками по результатам ЕГЭ
        /// </summary>
        /// <param name="path"></param>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SendEGESAles(string path, MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            await Client.SendTextMessageAsync(message.Chat.Id, "Ниже появится необходимый PDF файл:");
            HelpingFunctions.SendDocument(path, e, Client);
        }


        /// <summary>
        /// Вывод информации по получению скидок по результатам олимпиад
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static void SalesForOlymps(MessageEventArgs e, TelegramBotClient Client)
        {
            HelpingFunctions.SendDocument("SalesForOlymp.jpg", e, Client);
            Thread.Sleep(1000);
            HelpingFunctions.SendTextFromFile("SalesOLYMP.txt", e, Client);
        }


        /// <summary>
        /// Вывод информации по получению скидок по результатам обучения на ФДП
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static void SalesForFDP(MessageEventArgs e, TelegramBotClient Client)
        {
            HelpingFunctions.SendDocument("SalesForFDP.jpg", e, Client);
            Thread.Sleep(1000);
            HelpingFunctions.SendTextFromFile("SalesFDP.txt", e, Client);
        }


        /// <summary>
        /// Вывод информации по получении скидок для выпускников лицея ВШЭ
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static void SalesForLyceum(MessageEventArgs e, TelegramBotClient Client)
        {
            HelpingFunctions.SendDocument("SalesForLyceum.jpg", e, Client);
            Thread.Sleep(1000);
            HelpingFunctions.SendTextFromFile("SalesLYCEUM.txt", e, Client);
        }


        /// <summary>
        /// Вывод клавиатуры для выбора иных оснований для скидки
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void OtherSalesKeyboard(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;

            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Выпускникам базовых и ключевых региональных школ")
                },
                new[]
                {
                    new KeyboardButton("Выпускникам региональных центров")
                },
                new[]
                {
                    new KeyboardButton("Выпускникам школ Распределенного Лицея")
                },
                new[]
                {
                    new KeyboardButton("Выпускникам Физико – математической школы МИЭМ")
                },
                new[]
                {
                    new KeyboardButton("Вернуться назад"),
                    new KeyboardButton("Вернуться в главное меню")
                }
            });

            await Client.SendTextMessageAsync(message.Chat.Id, "Выберете доступный вариант:", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Предоставление информации о скидках для выпускников школы МИЭМа
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static void SalesMIEM(MessageEventArgs e, TelegramBotClient Client)
        {
            HelpingFunctions.SendDocument("SalesMIEM.jpg", e, Client);
            Thread.Sleep(1000);
            HelpingFunctions.SendTextFromFile("SalesMIEMInfo.txt", e, Client);
        }

        /// <summary>
        /// Предоставление информации о скидках для выпускников региональных школ
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SalesRegSch(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            HelpingFunctions.SendDocument("SalesRegionSch.jpg", e, Client);
            Thread.Sleep(1000);
            HelpingFunctions.SendTextFromFile("SalesREGSch.txt", e, Client);

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithUrl("Ссылка на перечень", "https://www.hse.ru/data/2019/05/21/1509761611/Реестр%20соглашений%20с%20базовыми%20школами%20на%202019%20год.pdf")
                }
            });
        
            await Client.SendTextMessageAsync(message.Chat.Id, "Перечень базовых школ:", replyMarkup: inlineKeyboard);
        }



        /// <summary>
        /// Предоставление информации о скидках для выпускников региональных центров
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SalesRegCenters(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            HelpingFunctions.SendDocument("SalesRegionCenters.jpg", e, Client);
            Thread.Sleep(1000);
            HelpingFunctions.SendTextFromFile("SalesREGCenters.txt", e, Client);

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithUrl("Ссылка на перечень", "https://fdp.hse.ru/regional")
                }
            });

            await Client.SendTextMessageAsync(message.Chat.Id, "Перечень региональных центров:", replyMarkup: inlineKeyboard);
        }


        /// <summary>
        /// Предоставление информации о скидках для выпускников распределенного лицея
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SalesRaspredLyceum(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            HelpingFunctions.SendDocument("SalesRaspredLyceum.jpg", e, Client);
            Thread.Sleep(1000);
            HelpingFunctions.SendTextFromFile("SalesRASPREDLyceum.txt", e, Client); 

            var inlineKeyboard = new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithUrl("Ссылка на перечень", "https://www.hse.ru/data/2019/02/15/1192445749/Список%20школ.pdf")
                }
            });

            await Client.SendTextMessageAsync(message.Chat.Id, "Перечень школ распределенного лицея:", replyMarkup: inlineKeyboard);
        }
    }
}
