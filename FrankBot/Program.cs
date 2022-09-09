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
            if ((await UserRepositore.UserIsRegisteredAsync(chatId)))
            {
                if (e.CallbackQuery.Data == "Start")
                {
                    await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenu());
                }
                else if (e.CallbackQuery.Data == "Currency")
                {
                    await client.SendTextMessageAsync(message.Chat.Id, Messages.CurrencyMenu, replyMarkup: Buttons.CurrencyMenu());
                }
                else if (e.CallbackQuery.Data == "Registration")
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
            }
        }
        [Obsolete]
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            Console.WriteLine(e.Message.Text);

            if (message.Text == "/start")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenu());
            }
        }
    }
}