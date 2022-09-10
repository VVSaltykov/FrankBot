using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrankBot.Models;
using Microsoft.EntityFrameworkCore;
using FrankBot.Exceptions;
using FrankBot.Repositories;

namespace FrankBot.Repositories
{
    public class UserRepositore
    {
        public static AppDBContext appDBContext = new AppDBContext();
        public static async Task<bool> UserIsRegisteredAsync(long chatId)
        {
            try
            {
                await GetUserByChatIdAsync(chatId);
                return true;
            }
            catch (NullException) 
            {
                return false;
            }
        }
        public static async Task<User> GetUserByChatIdAsync(long chatId)
        {
            var user = await appDBContext.Users.Where(u => u.ChatId == chatId).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new NullException();
            }
            return user;
        }
        public static async Task AddUserAsync(User user)
        {
            try
            {
                await appDBContext.Users.AddAsync(user);
                await appDBContext.SaveChangesAsync();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static async Task DeleteUserAsync(long chatId)
        {
            var user = GetUserByChatIdAsync(chatId);
            appDBContext.Users.Remove(await user);
            await appDBContext.SaveChangesAsync();
        }
        public static async Task MoneyAddAsync(long chatId, string message)
        {
            var user = await GetUserByChatIdAsync(chatId);
            user.Money = message;
            await appDBContext.SaveChangesAsync(); 
        }
        public static async Task<decimal> CalculationUSDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.USDReader();
            return calc;
        }
        public static async Task<decimal> CalculationAUDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.AUDReader();
            return calc;
        }
        public static async Task<decimal> CalculationAZNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.AZNReader();
            return calc;
        }
        public static async Task<decimal> CalculationGBPAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.GBPReader();
            return calc;
        }
        public static async Task<decimal> CalculationAMDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.AMDReader();
            return calc;
        }
        public static async Task<decimal> CalculationBYNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.BYNReader();
            return calc;
        }
        public static async Task<decimal> CalculationBGNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.BGNReader();
            return calc;
        }
        public static async Task<decimal> CalculationBRLAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.BRLReader();
            return calc;
        }
        public static async Task<decimal> CalculationHUFAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.HUFReader();
            return calc;
        }
        public static async Task<decimal> CalculationHKDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.HKDReader();
            return calc;
        }
        public static async Task<decimal> CalculationDKKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.DKKReader();
            return calc;
        }
        public static async Task<decimal> CalculationEURAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.EURReader();
            return calc;
        }
        public static async Task<decimal> CalculationINRAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.INRReader();
            return calc;
        }
        public static async Task<decimal> CalculationKZTAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.KZTReader();
            return calc;
        }
        public static async Task<decimal> CalculationCADAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.CADReader();
            return calc;
        }
        public static async Task<decimal> CalculationKGSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.KGSReader();
            return calc;
        }
        public static async Task<decimal> CalculationCNYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.CNYReader();
            return calc;
        }
        public static async Task<decimal> CalculationMDLAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.MDLReader();
            return calc;
        }
        public static async Task<decimal> CalculationNOKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.NOKReader();
            return calc;
        }
        public static async Task<decimal> CalculationPLNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.PLNReader();
            return calc;
        }
        public static async Task<decimal> CalculationRONAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.RONReader();
            return calc;
        }
        public static async Task<decimal> CalculationXDRAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.XDRReader();
            return calc;
        }
        public static async Task<decimal> CalculationSGDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.SGDReader();
            return calc;
        }
        public static async Task<decimal> CalculationTJSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.TJSReader();
            return calc;
        }
        public static async Task<decimal> CalculationTRYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.TRYReader();
            return calc;
        }
        public static async Task<decimal> CalculationTMTAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.TMTReader();
            return calc;
        }
        public static async Task<decimal> CalculationUZSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.UZSReader();
            return calc;
        }
        public static async Task<decimal> CalculationUAHAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.UAHReader();
            return calc;
        }
        public static async Task<decimal> CalculationCZKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.CZKReader();
            return calc;
        }
        public static async Task<decimal> CalculationSEKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.SEKReader();
            return calc;
        }
        public static async Task<decimal> CalculationCHFAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.CHFReader();
            return calc;
        }
        public static async Task<decimal> CalculationZARAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.ZARReader();
            return calc;
        }
        public static async Task<decimal> CalculationKRWAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.KRWReader();
            return calc;
        }
        public static async Task<decimal> CalculationJPYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = decimal.Parse(user.Money) * CurrentRepositore.JPYReader();
            return calc;
        }
    }
}
