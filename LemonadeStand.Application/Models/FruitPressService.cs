using LemonadeStand.Domain.Interfaces;
using LemonadeStand.Domain.Models;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Models
{
    public class FruitPressService : IFruitPressService
    {

        static List<IRecipe> availableRecipeList = new List<IRecipe>
        {
            new AppleLemonadeRecipe(),
            new MelonLemonadeRecipe(),
            new OrangeLemonadeRecipe()
        };

        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits,
            int moneyPaid, int orderedGlassQuantity)
        {
            IRecipe approvedRecipe = null;
            int totalCost = orderedGlassQuantity * recipe.PricePerGlass;

            foreach (var availableRecipe in availableRecipeList)
            {
                if (availableRecipe.Name == recipe.Name)
                {
                    approvedRecipe = availableRecipe;
                    break;
                }
            }

            // Denna if-sats skrivs ut om inget recept hittats
            if (approvedRecipe == null)
            {
                Console.WriteLine("approvedRecipe is null..");
                return null;
            }


            // Kontroller:
            // - Är det rätt frukt?
            bool allFruitsMatch = fruits.All(fruit => fruit.GetType() == recipe.AllowedFruit);
            if (!allFruitsMatch)
            {
                Console.WriteLine("Fruit not allowed");
                return null;
            }

            // - Räcker pengarna?
            if (totalCost > moneyPaid)
            {
                Console.WriteLine("totalCost is more than moneyPaid");
                return null;
            }

            // - Hur mycket frukt blir över?
            decimal remainingFruit = fruits.Count - recipe.ConsumptionPerGlass * orderedGlassQuantity;
            if (remainingFruit < 0)
            {
                Console.WriteLine("amount of fruit less than total fruit needed ://");
                return null;
            }
            else
            {
                Console.WriteLine($"remainingFruit = {remainingFruit} ");
            }

            return new FruitPressResult(true, "Successfully Produced Lemonade!", orderedGlassQuantity,
                remainingFruit, moneyPaid - totalCost);
        }
    }
}
