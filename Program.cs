using System;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using System.Threading;
using MihaZupan;
using System.Text.Json;
using System.Collections.Generic;

namespace TelegramBotHSE
{
    class MainClass
    {
        static TelegramBotClient Client; // Основаная переменная клиента

        /// <summary>
        /// Метод, обрабатывающий нажатие кнопок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Client_OnCallbackQuery(object sender, CallbackQueryEventArgs e)
        {
            string buttonText = e.CallbackQuery.Data; 
            Console.WriteLine(buttonText);
        }

        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // var proxy = new HttpToSocks5Proxy("185.10.57.107", 1234);

            Client = new TelegramBotClient("");

            Client.OnMessage += Client_MessageRecieved; // Принимаем сообщения от пользователя

            Client.OnCallbackQuery += Client_OnCallbackQuery;

            Client.StartReceiving();

            Console.ReadKey();
        }

        /// <summary>
        /// Метод, обрабатывающий получение сообщений от пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static async void Client_MessageRecieved(object sender, MessageEventArgs e)
        {
            // Текст для команды старта
            string textForTheStart = "Привет! Добро пожаловать! \n\nДля того, чтобы посмотреть основные команды бота, просто введи '/'." +
                "\n\nВсе необходимые команды доступны в виртуальной клавиатуре по команде /keyboard.";

            // Список, содержащий в себе строки информации из файла с направлениями, проходными баллами и т.д
            List<string> InfoNapravleniya = CSVReader.ReadCSV("Napravleniya.csv");


            if (e != null) // Проверяем, что отправленное сообщение не пустое
            {
                var message = e.Message;

                // Проверка ввода пользователем ТЕКСТА, а не фоток, аудио и так далее
                if (message.Type != MessageType.Text) 
                {
                    await Client.SendTextMessageAsync(message.Chat.Id, "Неверный тип отправленных данных, попробуйте ещё раз!");
                }
                else
                {
                    Console.WriteLine($"{e.Message.From.FirstName} {e.Message.From.LastName} sended this message : \"{e.Message.Text}\"");


                    // Обработка пользовательских вводов
                    switch (message.Text)
                    {
                        case "/start":
                            await Client.SendTextMessageAsync(message.Chat.Id, textForTheStart);
                            break;

                        case "Вернуться в главное меню":
                            MainMenuKeyboard.MainKeyBoard(e, Client);
                            break;

                        case "/keyboard":
                            MainMenuKeyboard.MainKeyBoard(e, Client);
                            break;

                        case "Полезные ссылки":
                            HelpfulLinks.ShowHelpfulLinks(e, Client);
                            break;

                        case "Поступление по олимпиадам":
                            Olympiads.OlympiadsMenu(e, Client);
                            break;



                        // РАЗДЕЛ ОЛИМПИАД
                        case "г. Москва":
                            Olympiads.SendOlymps("OlympMoscow.pdf", e, Client);
                            break;
                        case "г. Санкт-Петербург":
                            Olympiads.SendOlymps("OlympPiter.pdf", e, Client);
                            break;
                        case "г. Пермь":
                            Olympiads.SendOlymps("OlympPerm.pdf", e, Client);
                            break;
                        case "г. Нижний Новгород":
                            Olympiads.SendOlymps("OlympNovgorod.pdf", e, Client);
                            break;
                        // КОНЕЦ РАЗДЕЛА ОЛИМПИАД



                        // РАЗДЕЛ ПРИЁМНОЙ КОМИССИИ
                        case "Приёмная комиссия":
                            Priem.PriemnayaKomissiya(e, Client);
                            break;
                        case "Москва":
                            Priem.PriemMoscow(e, Client);
                            break;
                        case "Санкт-Петербург":
                            Priem.PriemPeterburg(e, Client);
                            break;
                        case "Пермь":
                            Priem.PriemPerm(e, Client);
                            break;
                        case "Нижний Новгород":
                            Priem.PriemNovgorod(e, Client);
                            break;
                        case "Контакты и режим работы, Москва":
                            Priem.InfoMoscow(e, Client);
                            break;
                        case "Приёмная комиссия на карте, Москва":
                            await Client.SendLocationAsync(message.Chat.Id, 55.761512f, 37.633177f);
                            break;
                        case "Контакты и режим работы, Санкт-Петербург":
                            Priem.InfoPiter(e, Client);
                            break;
                        case "Приёмная комиссия на карте, Санкт-Петербург":
                            await Client.SendLocationAsync(message.Chat.Id, 59.980277f, 30.326903f);
                            break;
                        case "Контакты и режим работы, Пермь":
                            Priem.InfoPerm(e, Client);
                            break;
                        case "Приёмная комиссия на карте, Пермь":
                            await Client.SendLocationAsync(message.Chat.Id, 58.010720f, 56.282006f);
                            break;
                        case "Контакты и режим работы, Нижний Новгород":
                            Priem.InfoNovgorod(e, Client);
                            break;
                        case "Приёмная комиссия на карте, Нижний Новгород":
                            await Client.SendLocationAsync(message.Chat.Id, 56.324904f, 44.021904f);
                            break;
                        case "Вернуться к списку городов":
                            Priem.PriemnayaKomissiya(e, Client);
                            break;
                        // КОНЕЦ РАЗДЕЛА ПРИЕМНОЙ КОМИССИИ



                        // РАЗДЕЛ СКИДОК
                        case "Скидки на обучение":
                            Sales.SalesMainMKeyboard(e, Client);
                            break;

                                // ЕГЭ 
                        case "По результатам ЕГЭ":
                            Sales.SalesEGE(e, Client);
                            break;
                        case "гор. Москва":
                            Sales.SendEGESAles("MoscowEGE.pdf", e, Client);
                            break;
                        case "гор. Санкт-Петербург":
                            Sales.SendEGESAles("PiterEGE.pdf", e, Client);
                            break;
                        case "гор. Пермь":
                            Sales.SendEGESAles("PermEGE.pdf", e, Client);
                            break;
                        case "гор. Нижний Новгород":
                            Sales.SendEGESAles("NovgorodEGE.pdf", e, Client);
                            break;
                                // Конец ЕГЭ

                        case "По результатам олимпиад":
                            Sales.SalesForOlymps(e, Client);
                            break;
                        case "Для выпускников ФДП":
                            Sales.SalesForFDP(e, Client);
                            break;
                        case "Для выпускников лицея ВШЭ":
                            Sales.SalesForLyceum(e, Client);
                            break;
                        case "Скидки по иным основаниям":
                            Sales.OtherSalesKeyboard(e, Client);
                            break;
                        case "Выпускникам базовых и ключевых региональных школ":
                            Sales.SalesRegSch(e, Client);
                            break;
                        case "Выпускникам региональных центров":
                            Sales.SalesRegCenters(e, Client);
                            break;
                        case "Выпускникам школ Распределенного Лицея":
                            Sales.SalesRaspredLyceum(e, Client);
                            break;
                        case "Выпускникам Физико – математической школы МИЭМ":
                            Sales.SalesMIEM(e, Client);
                            break;
                        case "Вернуться назад":
                            Sales.SalesMainMKeyboard(e, Client);
                            break;
                        case "Назад":
                            Sales.SalesMainMKeyboard(e, Client);
                            break;
                        // КОНЕЦ РАЗДЕЛА СКИДОК



                        // РАЗДЕЛ НАПРАВЛЕНИЙ ПОДГОТОВКИ
                        case "Направления подготовки":
                            //await Client.SendTextMessageAsync(message.Chat.Id, "Раздел находится на стадии разработки...");
                            //await Client.SendStickerAsync(message.Chat.Id, "CAACAgIAAxkBAAI7316CXMVPZwp81dp5y78X3c6Min06AAJbAQACT5wTAv8e4u2dM23QGAQ");

                            Napravleniya.CityMenuNapravleniya(e, Client);
                            break;

                        case "К выбору города":
                            Napravleniya.CityMenuNapravleniya(e, Client);
                            break;
                        case "К списку направлений": // Для Москвы (нет невидимых символов)
                            Napravleniya.MoscowFaculteti(e, Client);
                            break;

                                // МОСКВА НАПРАВЛЕНИЯ
                        case "Москва⁣":
                            Napravleniya.MoscowFaculteti(e, Client);
                            break;


                        case "Математика и механика":
                            Napravleniya.MechMath(e, Client);
                            break;
                        case "Математика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[0]);
                            break;
                        case "Совместный бакалавриат НИУ ВШЭ и Центра педагогического мастерства":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[1]);
                            break;
                        case "Прикладная математика и информатика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[2]);
                            break;
                        case "Программа двух дипломов НИУ ВШЭ и Лондонского университета «Прикладной анализ данных»":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[3]);
                            break;
                        case "Прикладная математика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[4]);
                            break;


                        case "Физика и астрономия":
                            Napravleniya.PhysAstr(e, Client);
                            break;
                        case "Физика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[5]);
                            break;


                        case "Химия⁣": // есть невидимый символ
                            Napravleniya.Himiya(e, Client);
                            break;
                        case "Химия":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[6]);
                            break;

                        case "Науки о земле":
                            Napravleniya.Geographiya(e, Client);
                            break;
                        case "География глобальных изменений и геоинформационные технологии":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[7]);
                            break;

                        case "Биологические науки":
                            Napravleniya.Biologiya(e, Client);
                            break;
                        case "Клеточная и молекулярная биотехнология":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[8]);
                            break;


                        case "Архитектура":
                            Napravleniya.Architectura(e, Client);
                            break;
                        case "Городское планирование":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[9]);
                            break;


                        case "Информатика и вычислительная техника⁣": // Есть невидимый символ
                            Napravleniya.InfTechn(e, Client);
                            break;
                        case "Информатика и вычислительная техника":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[10]);
                            break;
                        case "Программная инженерия":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[11]);
                            break;


                        case "Информационная безопасность⁣": // есть невидимый символ
                            Napravleniya.InfBez(e, Client);
                            break;
                        case "Информационная безопасность":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[12]);
                            break;
                        case "Компьютерная безопасность":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[13]);
                            break;


                        case "Электроника, радиоэлектроника и системы связи":
                            Napravleniya.ElectroRadio(e, Client);
                            break;
                        case "Инфокоммуникационные технологии и системы связи":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[14]);
                            break;


                        case "Психологические науки":
                            Napravleniya.Psychologiya(e, Client);
                            break;
                        case "Психология":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[15]);
                            break;



                        case "Экономика и управление":
                            Napravleniya.EconomUpravlenie(e, Client);
                            break;
                        case "Экономика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[16]);
                            break;
                        case "Совместная программа по экономике НИУ ВШЭ и РЭШ":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[17]);
                            break;
                        case "Экономика и статистика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[18]);
                            break;
                        case "Мировая экономика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[19]);
                            break;
                        case "Программа двух дипломов по экономике НИУ ВШЭ и Лондонского университета":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[20]);
                            break;
                        case "Управление бизнесом":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[21]);
                            break;
                        case "Маркетинг и рыночная аналитика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[22]);
                            break;
                        case "Управление логистикой и цепями поставок в бизнесе":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[23]);
                            break;
                        case "Государственное и муниципальное управление":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[24]);
                            break;
                        case "Бизнес-информатика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[25]);
                            break;
                        case "Цифровые инновации в управлении предприятием (программа двух дипломов НИУ ВШЭ и Лондонского университета)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[26]);
                            break;



                        case "Социология и социальная работа":
                            Napravleniya.Sociologiya(e, Client);
                            break;
                        case "Социология":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[27]);
                            break;



                        case "Юриспруденция⁣": // Есть невидимый символ
                            Napravleniya.Yurisprudenciya(e, Client);
                            break;
                        case "Юриспруденция":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[28]);
                            break;
                        case "Юриспруденция: частное право":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[29]);
                            break;


                        case "Политические науки и регионоведение":
                            Napravleniya.PolitRegion(e, Client);
                            break;
                        case "Программа двух дипломов НИУ ВШЭ и Университета Кёнхи «Экономика и политика в Азии":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[30]);
                            break;
                        case "Политология":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[31]);
                            break;
                        case "Международные отношения":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[32]);
                            break;
                        case "Программа двух дипломов НИУ ВШЭ и Лондонского университета по международным отношениям":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[33]);
                            break;




                        case "Средства массовой информации и информационно-библиотечное дело":
                            Napravleniya.SredstvaMassInfo(e, Client);
                            break;
                        case "Реклама и связи с общественностью":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[34]);
                            break;
                        case "Журналистика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[35]);
                            break;
                        case "Медиакоммуникации":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[36]);
                            break;





                        case "Языкознание и литературоведение":
                            Napravleniya.Yaziki(e, Client);
                            break;
                        case "Филология":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[37]);
                            break;
                        case "Античность⁣": // есть невидимый символ
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[38]);
                            break;
                        case "Иностранные языки и межкультурная коммуникация":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[39]);
                            break;
                        case "Фундаментальная и компьютерная лингвистика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[40]);
                            break;



                        case "История и археология":
                            Napravleniya.HistoryArcheology(e, Client);
                            break;
                        case "История":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[41]);
                            break;
                        case "Античность":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[42]);
                            break;



                        case "Философия, этика и религиоведение":
                            Napravleniya.Filosofiya(e, Client);
                            break;
                        case "Философия":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[43]);
                            break;



                        case "Искусствознание":
                            Napravleniya.Isscusstvo(e, Client);
                            break;
                        case "Современное искусство":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[44]);
                            break;
                        case "История искусств":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[45]);
                            break;



                        case "Культуроведение и социокультурные проекты":
                            Napravleniya.Kultura(e, Client);
                            break;
                        case "Культурология":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[46]);
                            break;



                        case "Изобразительное искусство и прикладные виды искусств":
                            Napravleniya.Design(e, Client);
                            break;
                        case "Дизайн":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[47]);
                            break;
                        case "Мода":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[48]);
                            break;



                        case "Востоковедение и африканистика":
                            Napravleniya.Vostok(e, Client);
                            break;
                        case "Востоковедение":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[49]);
                            break;
                        case "Турция и тюркский мир":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[50]);
                            break;
                        case "Монголия и Тибет":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[51]);
                            break;
                        case "Эфиопия и арабский мир":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[52]);
                            break;
                        // КОНЕЦ МОСКВА НАПРАВЛЕНИЯ


                        // НАПРАВЛЕНИЯ СПБ
                        case "Санкт-Петербург⁣":
                            NapravleniyaSPB.SPBFaculteti(e, Client);
                            break;
                        case "Прикладная математика и информатика (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[54]);
                            break;
                        case "Физика (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[55]);
                            break;
                        case "Экономика (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[56]);
                            break;
                        case "Международный бизнес и менеджмент":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[57]);
                            break;
                        case "Логистика и управление цепями поставок":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[58]);
                            break;
                        case "Управление и аналитика в государственном секторе":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[59]);
                            break;
                        case "Социология и социальная информатика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[60]);
                            break;
                        case "Юриспруденция (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[61]);
                            break;
                        case "Политология и мировая политика":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[62]);
                            break;
                        case "Филология (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[63]);
                            break;
                        case "История (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[64]);
                            break;
                        case "Дизайн (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[65]);
                            break;
                        case "Востоковедение (СПБ)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[66]);
                            break;
                        // КОНЕЦ НАПРАВЛЕНИЯ СПБ



                        // НАПРАВЛЕНИЯ ПЕРМЬ
                        case "Пермь⁣":
                            NapravleniyaPerm.PermFaculteti(e, Client);
                            break;
                        case "Программная инженерия (Пермь)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[68]);
                            break;
                        case "Экономика (Пермь)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[69]);
                            break;
                        case "Управление бизнесом (Пермь)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[70]);
                            break;
                        case "Бизнес-информатика (Пермь)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[71]);
                            break;
                        case "Юриспруденция (Пермь)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[72]);
                            break;
                        case "История (Пермь)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[73]);
                            break;
                        // КОНЕЦ НАПРАВЛЕНИЯ ПЕРМЬ


                        // НАПРАВЛЕНИЯ НОВГОРОД
                        case "Нижний Новгород⁣":
                            NapravleniyaNovgorod.NovgorodFaculteti(e, Client);
                            break;
                        case "Математика (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[75]);
                            break;
                        case "Прикладная математика и информатика (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[76]);
                            break;
                        case "Программная инженерия (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[77]);
                            break;
                        case "Экономика (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[78]);
                            break;
                        case "Управление бизнесом (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[79]);
                            break;
                        case "Бизнес-информатика (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[80]);
                            break;
                        case "Юриспруденция (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[81]);
                            break;
                        case "Филология (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[82]);
                            break;
                        case "Фундаментальная и прикладная лингвистика (Новгород)":
                            await Client.SendTextMessageAsync(message.Chat.Id, InfoNapravleniya[83]);
                            break;
                        // КОНЕЦ НАПРАВЛЕНИЯ НОВГОРОД

                        // КОНЕЦ РАЗДЕЛА НАПРАВЛЕНИЙ ПОДГОТОВКИ



                        // РАЗДЕЛ НЕ НАЙДЕННОЙ ИНФОРМАЦИИ
                        case "Не нашли ответ на вопрос?":
                            await Client.SendTextMessageAsync(message.Chat.Id, "Если вы не нашли интересующую вас информацию, вы можете обратиться напрямую" +
                                "в справочный центр ВШЭ по данному ниже электронному адресу: \n\nabitur@hse.ru \n\nТакже рекомендую посетить группу абитуриентов ВШЭ в ВК, " +
                                "где вы можете не только найти ответы на свои вопросы, но и задать их участникам. Переход по следующей ссылке: \n\nvk.com/ba_hse " +
                                "\n\nСвязаться с разработчиком можно через телеграм @arabianprinceee\n\n\n");
                            break;
                        // КОНЕЦ РАЗДЕЛА



                        // РАЗДЕЛ ЧАСТО ЗАДАВАЕМЫХ ВОПРОСОВ
                        case "Часто задаваемые вопросы":
                            await Client.SendTextMessageAsync(message.Chat.Id, "Раздел находится на стадии разработки...");
                            await Client.SendStickerAsync(message.Chat.Id, "CAACAgIAAxkBAAI7316CXMVPZwp81dp5y78X3c6Min06AAJbAQACT5wTAv8e4u2dM23QGAQ");
                            break;
                        // КОНЕЦ РАЗДЕЛА ЧАСТО ЗАДАВАЕМЫХ ВОПРОСОВ



                        default:
                            await Client.SendTextMessageAsync(message.Chat.Id, "К сожалению, введена неизвестная команда, попробуйте ещё раз!" +
                                "\n\nБот распознаёт только заданные текстовые команды, список основных команд вы можете увидеть, введя символ '/'." +
                                "\n\nВсе необходимые команды доступны в виртуальной клавиатуре по команде /keyboard.");
                            break;
                    }
                }
            }
        }

    }
}
