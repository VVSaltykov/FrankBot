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
        public static string Start = "Hi, this bot will help you find out the current exchange rate, according to the Central Bank of the Russian Federation.";
        public static string CurrencyMenu = "Select the currency you want to know the exchange rate of";
        public static string RegistrationMenu = "Hello, you are now registered, so the function of transferring a certain amount to another currency is available to you!";
        public static string FunctionsMenu = "Functions menu";
        public static string USD = $"At the moment, the USD to RUB exchange rate is as follows: {CurrentRepositore.USDReader()}";
        public static string EUR = $"At the moment, the EUR to RUB exchange rate is as follows: {CurrentRepositore.EURReader()}";
        public static string AUD = $"At the moment, the AUD to RUB exchange rate is as follows: {CurrentRepositore.AUDReader()}";
        public static string AZN = $"At the moment, the AZN to RUB exchange rate is as follows: {CurrentRepositore.AZNReader()}";
        public static string GBP = $"At the moment, the GBP to RUB exchange rate is as follows: {CurrentRepositore.GBPReader()}";
        public static string AMD = $"At the moment, the AMD to RUB exchange rate is as follows: {CurrentRepositore.AMDReader()}";
        public static string BYN = $"At the moment, the BYN to RUB exchange rate is as follows: {CurrentRepositore.BYNReader()}";
        public static string BGN = $"At the moment, the BGN to RUB exchange rate is as follows: {CurrentRepositore.BGNReader()}";
        public static string BRL = $"At the moment, the BRL to RUB exchange rate is as follows: {CurrentRepositore.BRLReader()}";
        public static string HUF = $"At the moment, the HUF to RUB exchange rate is as follows: {CurrentRepositore.HUFReader()}";
        public static string HKD = $"At the moment, the HKD to RUB exchange rate is as follows: {CurrentRepositore.HKDReader()}";
        public static string DKK = $"At the moment, the DKK to RUB exchange rate is as follows: {CurrentRepositore.DKKReader()}";
        public static string INR = $"At the moment, the INR to RUB exchange rate is as follows: {CurrentRepositore.INRReader()}";
        public static string KZT = $"At the moment, the KZT to RUB exchange rate is as follows: {CurrentRepositore.KZTReader()}";
        public static string CAD = $"At the moment, the CAD to RUB exchange rate is as follows: {CurrentRepositore.CADReader()}";
        public static string KGS = $"At the moment, the KGS to RUB exchange rate is as follows: {CurrentRepositore.KGSReader()}";
        public static string CNY = $"At the moment, the CNY to RUB exchange rate is as follows: {CurrentRepositore.CNYReader()}";
        public static string MDL = $"At the moment, the MDL to RUB exchange rate is as follows: {CurrentRepositore.MDLReader()}";
        public static string NOK = $"At the moment, the NOK to RUB exchange rate is as follows: {CurrentRepositore.NOKReader()}";
        public static string PLN = $"At the moment, the PLN to RUB exchange rate is as follows: {CurrentRepositore.PLNReader()}";
        public static string RON = $"At the moment, the RON to RUB exchange rate is as follows: {CurrentRepositore.RONReader()}";
        public static string XDR = $"At the moment, the XDR to RUB exchange rate is as follows: {CurrentRepositore.XDRReader()}";
        public static string SGD = $"At the moment, the SGD to RUB exchange rate is as follows: {CurrentRepositore.SGDReader()}";
        public static string TJS = $"At the moment, the TJS to RUB exchange rate is as follows: {CurrentRepositore.TJSReader()}";
        public static string TRY = $"At the moment, the TRY to RUB exchange rate is as follows: {CurrentRepositore.TRYReader()}";
        public static string TMT = $"At the moment, the TMT to RUB exchange rate is as follows: {CurrentRepositore.TMTReader()}";
        public static string UZS = $"At the moment, the UZS to RUB exchange rate is as follows: {CurrentRepositore.UZSReader()}";
        public static string UAH = $"At the moment, the UAH to RUB exchange rate is as follows: {CurrentRepositore.UAHReader()}";
        public static string CZK = $"At the moment, the CZK to RUB exchange rate is as follows: {CurrentRepositore.CZKReader()}";
        public static string SEK = $"At the moment, the SEK to RUB exchange rate is as follows: {CurrentRepositore.SEKReader()}";
        public static string CHF = $"At the moment, the CHF to RUB exchange rate is as follows: {CurrentRepositore.CHFReader()}";
        public static string ZAR = $"At the moment, the ZAR to RUB exchange rate is as follows: {CurrentRepositore.ZARReader()}";
        public static string KRW = $"At the moment, the KRW to RUB exchange rate is as follows: {CurrentRepositore.KRWReader()}";
        public static string JPY = $"At the moment, the JPY to RUB exchange rate is as follows: {CurrentRepositore.JPYReader()}";
    }
}
