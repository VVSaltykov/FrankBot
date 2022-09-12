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
            decimal calc = CurrentRepositore.USDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationAUDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.AUDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationAZNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.AZNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationGBPAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.GBPReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationAMDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.AMDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationBYNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.BYNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationBGNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.BGNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationBRLAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.BRLReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationHUFAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.HUFReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationHKDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.HKDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationDKKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.DKKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationEURAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.EURReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationINRAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.INRReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationKZTAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.KZTReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationCADAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CADReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationKGSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.KGSReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationCNYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CNYReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationMDLAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.MDLReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationNOKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.NOKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationPLNAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.PLNReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationRONAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.RONReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationXDRAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.XDRReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationSGDAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.SGDReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationTJSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.TJSReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationTRYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.TRYReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationTMTAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.TMTReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationUZSAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.UZSReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationUAHAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.UAHReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationCZKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CZKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationSEKAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.SEKReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationCHFAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.CHFReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationZARAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.ZARReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationKRWAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.KRWReader() / decimal.Parse(user.Money);
            return calc;
        }
        public static async Task<decimal> CalculationJPYAsync(long chatId)
        {
            var user = await GetUserByChatIdAsync(chatId);
            decimal calc = CurrentRepositore.JPYReader() / decimal.Parse(user.Money);
            return calc;
        }
    }
}
