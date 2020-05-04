using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace TelegramBotHSE
{
    [Serializable]
    public class TestClass
    {
        public static async void TestSerialize(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            ReplyKeyboardMarkup replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Моawwq"),
                    new KeyboardButton("Санкбург⁣")
                },
                new[]
                {
                    new KeyboardButton("Прмь⁣"),
                    new KeyboardButton("Нижгоод⁣")
                },
                new[]
                {
                    new KeyboardButton("Вернутное меню")
                }
            });

            string json = JsonSerializer.Serialize(replyKeyBoard);
            HelpingFunctions.WriteToTextFile("TestClassSer.txt", json);
            json = HelpingFunctions.ReturnTextFromFile("TestClassSer.txt");
            ReplyKeyboardMarkup KeyBoard = JsonSerializer.Deserialize<ReplyKeyboardMarkup>(json);
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужный город", replyMarkup: KeyBoard);
        }

        

    }
}
