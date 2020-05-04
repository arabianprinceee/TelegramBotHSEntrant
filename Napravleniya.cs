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
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Москва⁣"),
                    new KeyboardButton("Санкт-Петербург⁣")
                },
                new[]
                {
                    new KeyboardButton("Пермь⁣"),
                    new KeyboardButton("Нижний Новгород⁣")
                },
                new[]
                {
                    new KeyboardButton("Вернуться в главное меню")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите нужный город", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Меню с Московскими факультетами
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void MoscowFaculteti(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Математика и механика")
                },
                new[]
                {
                    new KeyboardButton("Физика и астрономия")
                },
                new[]
                {
                    new KeyboardButton("Химия⁣") // есть невидимый символ
                },
                new[]
                {
                    new KeyboardButton("Науки о земле")
                },
                new[]
                {
                    new KeyboardButton("Биологические науки")
                },
                new[]
                {
                    new KeyboardButton("Архитектура")
                },
                new[]
                {
                    new KeyboardButton("Информатика и вычислительная техника⁣") // есть невидимый символ
                },
                new[]
                {
                    new KeyboardButton("Информационная безопасность⁣") // есть невидимый символ
                },
                new[]
                {
                    new KeyboardButton("Электроника, радиоэлектроника и системы связи")
                },
                new[]
                {
                    new KeyboardButton("Психологические науки")
                },
                new[]
                {
                    new KeyboardButton("Экономика и управление")
                },
                new[]
                {
                    new KeyboardButton("Социология и социальная работа")
                },
                new[]
                {
                    new KeyboardButton("Юриспруденция⁣") // Есть невидимый символ
                },
                new[]
                {
                    new KeyboardButton("Политические науки и регионоведение")
                },
                new[]
                {
                    new KeyboardButton("Средства массовой информации и информационно-библиотечное дело")
                },
                new[]
                {
                    new KeyboardButton("Языкознание и литературоведение")
                },
                new[]
                {
                    new KeyboardButton("История и археология")
                },
                new[]
                {
                    new KeyboardButton("Философия, этика и религиоведение")
                },
                new[]
                {
                    new KeyboardButton("Искусствознание")
                },
                new[]
                {
                    new KeyboardButton("Культуроведение и социокультурные проекты")
                },
                new[]
                {
                    new KeyboardButton("Изобразительное искусство и прикладные виды искусств")
                },
                new[]
                {
                    new KeyboardButton("Востоковедение и африканистика")
                },
                new[]
                {
                    new KeyboardButton("К выбору города")
                },
                new[]
                {
                    new KeyboardButton("Вернуться в главное меню")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите интересующий вас факультет", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Математики и механики
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void MechMath(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Математика")
                },
                new[]
                {
                    new KeyboardButton("Совместный бакалавриат НИУ ВШЭ и Центра педагогического мастерства")
                },
                new[]
                {
                    new KeyboardButton("Прикладная математика и информатика")
                },
                new[]
                {
                    new KeyboardButton("Прикладная математика")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Физики
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PhysAstr(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Физика")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Химии
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Himiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Химия")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Географии
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Geographiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("География глобальных изменений и геоинформационные технологии")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }


        /// <summary>
        /// Клавиатура для факультета Биологические науки
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Biologiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Клеточная и молекулярная биотехнология")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Архитектура
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Architectura(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Городское планирование")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Информатика
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfTechn(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Информатика и вычислительная техника")
                },
                new[]
                {
                    new KeyboardButton("Программная инженерия")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета ИнфБез
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void InfBez(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Информационная безопасность")
                },
                new[]
                {
                    new KeyboardButton("Компьютерная безопасность")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Электроника, радиотехника
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void ElectroRadio(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Инфокоммуникационные технологии и системы связи")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Психология
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Psychologiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Психология")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Экономика и управление
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void EconomUpravlenie(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Экономика")
                },
                new[]
                {
                    new KeyboardButton("Совместная программа по экономике НИУ ВШЭ и РЭШ")
                },
                new[]
                {
                    new KeyboardButton("Экономика и статистика")
                },
                new[]
                {
                    new KeyboardButton("Мировая экономика")
                },
                new[]
                {
                    new KeyboardButton("Программа двух дипломов по экономике НИУ ВШЭ и Лондонского университета")
                },
                new[]
                {
                    new KeyboardButton("Управление бизнесом")
                },
                new[]
                {
                    new KeyboardButton("Маркетинг и рыночная аналитика")
                },
                new[]
                {
                    new KeyboardButton("Управление логистикой и цепями поставок в бизнесе")
                },
                new[]
                {
                    new KeyboardButton("Государственное и муниципальное управление")
                },
                new[]
                {
                    new KeyboardButton("Бизнес-информатика")
                },
                new[]
                {
                    new KeyboardButton("Цифровые инновации в управлении предприятием (программа двух дипломов НИУ ВШЭ и Лондонского университета)")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }

            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Социология
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Sociologiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Социология")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Юриспруденция
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Yurisprudenciya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Юриспруденция")
                },
                new[]
                {
                    new KeyboardButton("Юриспруденция: частное право")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Политические науки
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void PolitRegion(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Программа двух дипломов НИУ ВШЭ и Университета Кёнхи «Экономика и политика в Азии")
                },
                new[]
                {
                    new KeyboardButton("Политология")
                },
                new[]
                {
                    new KeyboardButton("Международные отношения")
                },
                new[]
                {
                    new KeyboardButton("Программа двух дипломов НИУ ВШЭ и Лондонского университета по международным отношениям")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Средства массовой информации и тд
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void SredstvaMassInfo(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Реклама и связи с общественностью")
                },
                new[]
                {
                    new KeyboardButton("Журналистика")
                },
                new[]
                {
                    new KeyboardButton("Медиакоммуникации")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Языкознание
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Yaziki(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Филология")
                },
                new[]
                {
                    new KeyboardButton("Античность⁣")
                },
                new[]
                {
                    new KeyboardButton("Иностранные языки и межкультурная коммуникация")
                },
                new[]
                {
                    new KeyboardButton("Фундаментальная и компьютерная лингвистика")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета История
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void HistoryArcheology(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("История")
                },
                new[]
                {
                    new KeyboardButton("Античность")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Философия
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Filosofiya(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Философия")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Искусствознание
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Isscusstvo(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Современное искусство")
                },
                new[]
                {
                    new KeyboardButton("История искусств")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Культурология
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Kultura(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Культурология")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Дизайн
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Design(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Дизайн")
                },
                new[]
                {
                    new KeyboardButton("Мода")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

        /// <summary>
        /// Клавиатура для факультета Востоковедение и африканистика
        /// </summary>
        /// <param name="e"></param>
        /// <param name="Client"></param>
        public static async void Vostok(MessageEventArgs e, TelegramBotClient Client)
        {
            var message = e.Message;
            var replyKeyBoard = new ReplyKeyboardMarkup(new[]
            {
                new[]
                {
                    new KeyboardButton("Востоковедение")
                },
                new[]
                {
                    new KeyboardButton("Турция и тюркский мир")
                },
                new[]
                {
                    new KeyboardButton("Монголия и Тибет")
                },
                new[]
                {
                    new KeyboardButton("Эфиопия и арабский мир")
                },
                new[]
                {
                    new KeyboardButton("К списку направлений")
                }
            });
            await Client.SendTextMessageAsync(message.Chat.Id, "Выберите направление подготовки", replyMarkup: replyKeyBoard);
        }

    }
}
