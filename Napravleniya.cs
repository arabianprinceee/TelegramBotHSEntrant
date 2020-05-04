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
    public static class Napravleniya
    {
        /// <summary>
        /// Меню с выбором городов в разделе "направления"
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void CityMenuNapravleniya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("CityMenuNapravleniyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужный город", replyMarkup: KeyBoard);
        }



        /// <summary>
        /// Меню с Московскими факультетами
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void MoscowFaculteti(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("MoscowFacultetiSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите интересующий вас факультет", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Математики и механики
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void MechMath(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("MechMathSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Физики
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PhysAstr(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PhysAstrSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Химии
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Himiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("HimiyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Географии
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Geographiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("GeographiyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }


        /// <summary>
        /// Клавиатура для факультета Биологические науки
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Biologiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("BiologiyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Архитектура
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Architectura(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("ArchitecturaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Информатика
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfTechn(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("InfTechnSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета ИнфБез
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfBez(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("InfBezSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Электроника, радиотехника
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void ElectroRadio(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("ElectroRadioSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Психология
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Psychologiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PsychologiyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Экономика и управление
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void EconomUpravlenie(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("EconomUpravlenieSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Социология
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Sociologiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("SociologiyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Юриспруденция
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Yurisprudenciya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("YurisprudenciyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Политические науки
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PolitRegion(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("PolitRegionSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Средства массовой информации и тд
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SredstvaMassInfo(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("SredstvaMassInfoSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Языкознание
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Yaziki(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("YazikiSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета История
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void HistoryArcheology(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("HistoryArcheologySer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Философия
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Filosofiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("FilosofiyaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Искусствознание
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Isscusstvo(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("IsscusstvoSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Культурология
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Kultura(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("KulturaSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Дизайн
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Design(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("DesignSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Востоковедение и африканистика
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Vostok(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            string json = HelpingFunctions.ReturnTextFromFile("VostokSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: KeyBoard);
        }

    }
}
