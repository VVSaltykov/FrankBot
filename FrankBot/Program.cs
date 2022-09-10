using FrankBot.Exceptions;
using FrankBot.Models;
using FrankBot.Repositories;
using FrankBot.UI;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace FrankBot
{
    public class Program
    {
        private static string Token { get; set; } = "5420615001:AAGSUWfCpdXuCdbpwo45q4hVMt2DfRUZWSQ";
        private static TelegramBotClient client;
        private static List<(long chatId, string attribute)> RedactionData = new();
        [Obsolete]
        static void Main()
        {
            try
            {
                client = new TelegramBotClient(Token);
                client.StartReceiving();
                client.OnMessage += OnMessageHandler;
                client.OnCallbackQuery += OnCallbackQweryHandlerAsync;
                Console.ReadLine();
                client.StopReceiving();
            }
            catch
            {
                Console.WriteLine("ERROR");
                Console.ReadLine();
            }
        }
        [Obsolete]
        private static async void OnCallbackQweryHandlerAsync(object sender, CallbackQueryEventArgs e)
        {
            var message = e.CallbackQuery.Message;
            long chatId = e.CallbackQuery.Message.Chat.Id;
            Console.WriteLine(e.CallbackQuery.Data);
            if (e.CallbackQuery.Data == "Start")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenu());
            }
            try
            {
                if (e.CallbackQuery.Data == "Registration")
                {
                    if (await UserRepositore.UserIsRegisteredAsync(chatId))
                    {
                        await UserRepositore.DeleteUserAsync(chatId);
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.RegistrationMenu);
                        await UserRepositore.AddUserAsync(new User
                        {
                            ChatId = chatId
                        });
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.RegistrationMenu);
                        await UserRepositore.AddUserAsync(new User
                        {
                            ChatId = chatId
                        });
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                }
                else if (!(await UserRepositore.UserIsRegisteredAsync(chatId)))
                {
                    if (e.CallbackQuery.Data == "Currency")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CurrencyMenu, replyMarkup: Buttons.CurrencyMenu());
                    }

                    else if (e.CallbackQuery.Data == "USD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.USD, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "EUR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.EUR, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "AUD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AUD, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "AZN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AZN, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "GBP")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.GBP, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "AMD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AMD, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "BYN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BYN, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "BGN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BGN, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "BRL")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BRL, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "HUF")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.HUF, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "HKD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.HKD, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "DKK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.DKK, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "INR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.INR, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "KZT")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KZT, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "CAD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CAD, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "KGS")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KGS, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "CNY")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CNY, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "MDL")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.MDL, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "NOK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.NOK, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "PLN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.PLN, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "RON")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.RON, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "XDR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.XDR, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "SGD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.SGD, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "TJS")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TJS, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "TRY")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TRY, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "TMT")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TMT, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "UZS")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.UZS, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "UAH")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.UAH, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "CZK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CZK, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "SEK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.SEK, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "CHF")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CHF, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "ZAR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.ZAR, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "KRW")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KRW, replyMarkup: Buttons.StartMenu());
                    }
                    else if (e.CallbackQuery.Data == "JPY")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.JPY, replyMarkup: Buttons.StartMenu());
                    }
                }
                else
                {
                    if (e.CallbackQuery.Data == "Start")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "Functions")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.FunctionsMenu, replyMarkup: Buttons.FunctionsMenu());
                    }
                    else if (e.CallbackQuery.Data == "Money")
                    {
                        await client.EditMessageTextAsync(message.Chat.Id, message.MessageId, "Input value");
                        RedactionData.Add((chatId, "Money"));
                    }
                    else if (e.CallbackQuery.Data == "Currency")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CurrencyMenu, replyMarkup: Buttons.CurrencyMenu());
                    }
                    else if (e.CallbackQuery.Data == "USD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.USD, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "EUR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.EUR, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "AUD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AUD, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "AZN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AZN, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "GBP")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.GBP, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "AMD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AMD, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "BYN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BYN, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "BGN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BGN, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "BRL")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BRL, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "HUF")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.HUF, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "HKD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.HKD, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "DKK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.DKK, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "INR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.INR, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "KZT")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KZT, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "CAD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CAD, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "KGS")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KGS, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "CNY")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CNY, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "MDL")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.MDL, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "NOK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.NOK, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "PLN")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.PLN, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "RON")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.RON, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "XDR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.XDR, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "SGD")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.SGD, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "TJS")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TJS, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "TRY")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TRY, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "TMT")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TMT, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "UZS")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.UZS, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "UAH")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.UAH, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "CZK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CZK, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "SEK")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.SEK, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "CHF")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CHF, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "ZAR")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.ZAR, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "KRW")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KRW, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "JPY")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.JPY, replyMarkup: Buttons.StartMenuAfterReg());
                    }
                    else if (e.CallbackQuery.Data == "Calculation")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.Calculation, replyMarkup: Buttons.CalculationCurrencyMenu());
                    }
                    else if (e.CallbackQuery.Data == "USDCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.USD);
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationUSDAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "EURCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.EUR, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationEURAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "AUDCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AUD, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationAUDAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "AZNCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AZN, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationAZNAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "GBPCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.GBP, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationGBPAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "AMDCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.AMD, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationAMDAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "BYNCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BYN, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationBYNAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "BGNCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BGN, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationBGNAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "BRLCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.BRL, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationBRLAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "HUFCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.HUF, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationHUFAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "HKDCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.HKD, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationHKDAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "DKKCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.DKK, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationDKKAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "INRCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.INR, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationINRAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "KZTCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KZT, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationKZTAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "CADCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CAD, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationCADAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "KGSCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KGS, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationKGSAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "CNYCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CNY, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationCNYAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "MDLCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.MDL, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationMDLAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "NOKCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.NOK, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationNOKAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "PLNCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.PLN, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationPLNAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "RONCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.RON, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationRONAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "XDRCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.XDR, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationXDRAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "SGDCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.SGD, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationSGDAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "TJSCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TJS, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationTJSAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "TRYCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TRY, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationTRYAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "TMTCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.TMT, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationTMTAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "UZSCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.UZS, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationUZSAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "UAHCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.UAH, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationUAHAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "CZKCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CZK, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationCZKAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "SEKCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.SEK, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationSEKAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "CHFCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.CHF, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationCHFAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "ZARCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.ZAR, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationZARAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "KRWCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.KRW, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationKRWAsync(chatId)}");
                    }
                    else if (e.CallbackQuery.Data == "JPYCalc")
                    {
                        await client.SendTextMessageAsync(message.Chat.Id, Messages.JPY, replyMarkup: Buttons.StartMenuAfterReg());
                        await client.SendTextMessageAsync(message.Chat.Id, $"{await UserRepositore.CalculationJPYAsync(chatId)}");
                    }
                }
            }
            catch (NullException)
            {
                throw new NullException();
            }
        }
        [Obsolete]
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            long chatId = e.Message.Chat.Id;
            Console.WriteLine(e.Message.Text);

            if (message.Text == "/start")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenu());
            }
            else if (RedactionData.Any())
            {
                foreach (var data in RedactionData)
                {
                    if (data.attribute == "Money")
                    {
                        var user = await UserRepositore.GetUserByChatIdAsync(chatId);
                        await UserRepositore.MoneyAddAsync(chatId, message.Text);
                        await client.SendTextMessageAsync(message.Chat.Id, $"Your parameters:\n" +
                            $"ChatId: {user.ChatId}\n" +
                            $"Money: {user.Money}\n", replyMarkup: Buttons.StartMenuAfterReg());
                    }
                }
            }
        }
    }
}