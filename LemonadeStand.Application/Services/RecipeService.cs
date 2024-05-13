using LemonadeStand.Domain.Interfaces;
using LemonadeStand.Domain.Models;

namespace LemonadeStand.Application.Services
{
    public class RecipeService
    {
        public static List<IRecipe> GetRecipes()
        {
            return new List<IRecipe>
            {
                new Recipe("Apple Lemonade", typeof(Apple), 2.5m, 10),
                new Recipe("Melon Lemonade", typeof(Melon), 0.5m, 12),
                new Recipe("Orange Lemonade", typeof(Orange), 1m, 9)
            };
        }
    }
}