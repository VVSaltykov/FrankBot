using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrankBot.Repositories;

namespace FrankBot.UI
{
    public class Messages
    {
        public static string Start = "Hi, this bot will help you find out the current exchange rate, according to the Central Bank of the Russian Federation";
        public static string CurrencyMenu = "Select the currency you want to know the exchange rate of";
        public static string USD = $"At the moment, the USD to RUB exchange rate is as follows: {CurrentRepositore.USDReader()}";
        public static string EUR = $"At the moment, the EUR to RUB exchange rate is as follows: {CurrentRepositore.EURReader()}";
    }
}
