using DatesApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace DatesApp.Data
{
    public class Seed
    {
        public static async Task SeedUsers(DataContext context)
        {
            if (await context.Users.AnyAsync()) return;

            var userData = await File.ReadAllTextAsync("Data/UserSeedData.json");
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var users = JsonSerializer.Deserialize<List<User>>(userData, options);

            foreach (var user in users!)
            {
                using (var hmac = new HMACSHA512())
                {
                    user.PasswordSalt = new byte[64];
                    using (var rng = RandomNumberGenerator.Create())
                    {
                        rng.GetBytes(user.PasswordSalt);
                    }

                    user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("password"));
                }

                context.Users.Add(user);
            }

            await context.SaveChangesAsync();
        }
    }
}
