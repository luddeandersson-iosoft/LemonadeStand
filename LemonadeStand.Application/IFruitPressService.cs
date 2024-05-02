using System.Collections.ObjectModel;
using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Application
{
    public interface IFruitPressService
    {
        FruitPressResult Produce(IRecipe recipe, Collection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity);
    }
}