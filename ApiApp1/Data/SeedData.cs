using Microsoft.EntityFrameworkCore;
using ApiApp1.Models;

namespace ApiApp1.Data
{
    public class SeedData
    {
        public static void Initialize(FishDbContext context)
        {
            if (!context.FishCatchs.Any())
            {
                context.FishCatchs.Add(new FishCatch
                {
                    Id = 0,
                    Name = string.Empty,
                    Size = 0,
                    Rarity = "Common",
                    CaughtAt = DateTime.Now

                });

                context.SaveChanges();//データベースに保存する
            }
        }
    }
}
