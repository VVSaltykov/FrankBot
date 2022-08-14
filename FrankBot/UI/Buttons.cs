using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace FrankBot.UI
{
    public class Buttons
    {
        public static IReplyMarkup Start()
        {
            return new InlineKeyboardMarkup(new List<List<InlineKeyboardButton>>
            {
                    new List<InlineKeyboardButton>
                    {
                        InlineKeyboardButton.WithCallbackData(text: "Start", callbackData: "Start")
                    },
            });
            ;
        }
        public static IReplyMarkup CurrencyMenu()
        {
            return new InlineKeyboardMarkup(new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "AUD", callbackData: "AUD"),
                    InlineKeyboardButton.WithCallbackData(text: "AZN", callbackData: "AZN"),
                    InlineKeyboardButton.WithCallbackData(text: "GBP", callbackData: "GBP")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "AMD", callbackData: "AMD"),
                    InlineKeyboardButton.WithCallbackData(text: "BYN", callbackData: "BYN"),
                    InlineKeyboardButton.WithCallbackData(text: "BGN", callbackData: "BGN")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "BRL", callbackData: "BRL"),
                    InlineKeyboardButton.WithCallbackData(text: "HUF", callbackData: "HUF"),
                    InlineKeyboardButton.WithCallbackData(text: "HKD", callbackData: "HKD")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "DKK", callbackData: "DKK"),
                    InlineKeyboardButton.WithCallbackData(text: "USD", callbackData: "USD"),
                    InlineKeyboardButton.WithCallbackData(text: "EUR", callbackData: "EUR")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "INR", callbackData: "INR"),
                    InlineKeyboardButton.WithCallbackData(text: "KZT", callbackData: "KZT"),
                    InlineKeyboardButton.WithCallbackData(text: "CAD", callbackData: "CAD")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "KGS", callbackData: "KGS"),
                    InlineKeyboardButton.WithCallbackData(text: "CNY", callbackData: "CNY"),
                    InlineKeyboardButton.WithCallbackData(text: "MDL", callbackData: "MDL")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "NOK", callbackData: "NOK"),
                    InlineKeyboardButton.WithCallbackData(text: "PLN", callbackData: "PLN"),
                    InlineKeyboardButton.WithCallbackData(text: "RON", callbackData: "RON")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "XDR", callbackData: "XDR"),
                    InlineKeyboardButton.WithCallbackData(text: "SGD", callbackData: "SGD"),
                    InlineKeyboardButton.WithCallbackData(text: "TJS", callbackData: "TJS")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "TRY", callbackData: "TRY"),
                    InlineKeyboardButton.WithCallbackData(text: "TMT", callbackData: "TMT"),
                    InlineKeyboardButton.WithCallbackData(text: "UZS", callbackData: "UZS")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "UAH", callbackData: "UAH"),
                    InlineKeyboardButton.WithCallbackData(text: "CZK", callbackData: "CZK"),
                    InlineKeyboardButton.WithCallbackData(text: "SEK", callbackData: "SEK")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "CHF", callbackData: "CHF"),
                    InlineKeyboardButton.WithCallbackData(text: "ZAR", callbackData: "ZAR"),
                    InlineKeyboardButton.WithCallbackData(text: "KRW", callbackData: "KRW")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "JPY", callbackData: "JPY")
                },
            });
        }
    }
}
