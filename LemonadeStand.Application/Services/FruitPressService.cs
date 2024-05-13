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
            return new FruitPressResult(true, "Successfully Produced Lemonade!", orderedGlassQuantity,
                CalculateRemainingFruits(recipe, fruits, orderedGlassQuantity), CalculatePayment(recipe, orderedGlassQuantity, moneyPaid));
        }


        private int CalculatePayment(IRecipe recipe, int orderedGlassQuantity, int moneyPaid)
        {
            return moneyPaid - recipe.PricePerGlass * orderedGlassQuantity;
        }

        private decimal CalculateRemainingFruits(IRecipe recipe, Collection<IFruit> fruits, int orderedGlassQuantity)
        {
            return fruits.Count - recipe.ConsumptionPerGlass * orderedGlassQuantity;
        }
    }
}
