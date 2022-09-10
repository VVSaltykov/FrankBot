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
    }
}
