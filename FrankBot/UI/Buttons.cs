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
        public static IReplyMarkup StartMenu()
        {
            return new InlineKeyboardMarkup(new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Currency", callbackData: "Currency"),
                    InlineKeyboardButton.WithCallbackData(text: "Registration", callbackData: "Registration")
                }
            });
        }
        public static IReplyMarkup StartMenuAfterReg()
        {
            return new InlineKeyboardMarkup(new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Currency", callbackData: "Currency"),
                    InlineKeyboardButton.WithCallbackData(text: "Functions", callbackData: "Functions")
                }
            });
        }
        public static IReplyMarkup FunctionsMenu()
        {
            return new InlineKeyboardMarkup(new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "Money", callbackData: "Money"),
                    InlineKeyboardButton.WithCallbackData(text: "Calculation", callbackData: "Calculation")
                }
            });
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
        public static IReplyMarkup CalculationCurrencyMenu()
        {
            return new InlineKeyboardMarkup(new List<List<InlineKeyboardButton>>
            {
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "AUD", callbackData: "AUDCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "AZN", callbackData: "AZNCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "GBP", callbackData: "GBPCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "AMD", callbackData: "AMDCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "BYN", callbackData: "BYNCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "BGN", callbackData: "BGNCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "BRL", callbackData: "BRLCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "HUF", callbackData: "HUFCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "HKD", callbackData: "HKDCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "DKK", callbackData: "DKKCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "USD", callbackData: "USDCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "EUR", callbackData: "EURCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "INR", callbackData: "INRCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "KZT", callbackData: "KZTCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "CAD", callbackData: "CADCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "KGS", callbackData: "KGSCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "CNY", callbackData: "CNYCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "MDL", callbackData: "MDLCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "NOK", callbackData: "NOKCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "PLN", callbackData: "PLNCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "RON", callbackData: "RONCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "XDR", callbackData: "XDRCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "SGD", callbackData: "SGDCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "TJS", callbackData: "TJSCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "TRY", callbackData: "TRYCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "TMT", callbackData: "TMTCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "UZS", callbackData: "UZSCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "UAH", callbackData: "UAHCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "CZK", callbackData: "CZKCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "SEK", callbackData: "SEKCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "CHF", callbackData: "CHFCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "ZAR", callbackData: "ZARCalc"),
                    InlineKeyboardButton.WithCallbackData(text: "KRW", callbackData: "KRWCalc")
                },
                new List<InlineKeyboardButton>
                {
                    InlineKeyboardButton.WithCallbackData(text: "JPY", callbackData: "JPYCalc")
                },
            });
        }
    }
}
