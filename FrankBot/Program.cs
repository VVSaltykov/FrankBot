using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Args;

namespace FrankBot
{
    internal class Program
    {
        private static string Token { get; set; } = "";//TODO - insert correct token
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

        }
        [Obsolete]
        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {

        }
    }
}