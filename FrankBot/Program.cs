using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;
using FrankBot.UI;

namespace FrankBot
{
    internal class Program
    {
        private static string Token { get; set; } = "5420615001:AAFyzW5U7T4cuoGZ2UNEl7X8EAr_iNsBhgc";//TODO - insert correct token
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

            if (e.CallbackQuery.Data == "Start")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.Start());
            }
            else if (e.CallbackQuery.Data == "Currency")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.CurrencyMenu, replyMarkup: Buttons.CurrencyMenu());
            }
            else if (e.CallbackQuery.Data == "USD")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.USD, replyMarkup: Buttons.Start());
            }
            else if (e.CallbackQuery.Data == "EUR")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.EUR, replyMarkup: Buttons.Start());
            }
        }
        [Obsolete]
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var message = e.Message;

            if (message.Text == "/start")
            {
                await client.SendTextMessageAsync(message.Chat.Id, Messages.Start, replyMarkup: Buttons.StartMenu());
            }
        }
    }
}