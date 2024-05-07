using LemonadeStand.Application.Interfaces;
using LemonadeStand.Domain.Interfaces;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Services
{
    public class FruitPressService : IFruitPressService
    {

        public FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits,
            int moneyPaid, int orderedGlassQuantity)
        {
            int totalCost = orderedGlassQuantity * recipe.PricePerGlass;
            decimal remainingFruit = fruits.Count - recipe.ConsumptionPerGlass * orderedGlassQuantity;

            return new FruitPressResult(true, "Successfully Produced Lemonade!", orderedGlassQuantity,
                remainingFruit, moneyPaid - totalCost);
        }

        // Validation här? Tveksam
        // Try/catch för inputs?
        // Bryt ut och skala ner denna klass?

    }
}
