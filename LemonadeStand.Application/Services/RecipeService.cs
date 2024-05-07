using LemonadeStand.Domain.Interfaces;
using LemonadeStand.Domain.Models;

namespace LemonadeStand.Application.Services
{
    public class RecipeService
    {
        public static List<IRecipe> GetRecipes()
        {
            List<IRecipe> availableRecipeList = new List<IRecipe>
            {
                new Recipe("Apple Lemonade", typeof(Apple), 2.5m, 10),
                new Recipe("Melon Lemonade", typeof(Melon), 0.5m, 12),
                new Recipe("Orange Recipe", typeof(Orange), 1m, 9)
            };

            return availableRecipeList;
        }
    }
}
