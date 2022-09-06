using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrankBot.Models;
using Microsoft.EntityFrameworkCore;
using FrankBot.Exceptions;

namespace FrankBot.Repositories
{
    public class UserRepositore
    {
        public static AppDBContext appDbContext;
        public static async Task<bool> UserIsRegisteredAsync(long chatId)
        {
            try
            {
                await GetUserByChatIdAsync(chatId);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static async Task<User> GetUserByChatIdAsync(long chatId)
        {
            var user = await appDbContext.Users.FirstOrDefaultAsync(u => u.ChatId == chatId);
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
                await appDbContext.Users.AddAsync(user);
                await appDbContext.SaveChangesAsync();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static async Task DeleteUserAsync(long chatId)
        {
            var user = GetUserByChatIdAsync(chatId);
            appDbContext.Users.Remove(await user);
            await appDbContext.SaveChangesAsync();
        }
    }
}
