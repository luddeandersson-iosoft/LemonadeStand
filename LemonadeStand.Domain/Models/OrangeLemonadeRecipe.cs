using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Domain.Models
{
    public class OrangeLemonadeRecipe : IRecipe
    {
        public string Name { get; private set; }

        public Type AllowedFruit { get; private set; }

        public decimal ConsumptionPerGlass { get; private set; }

        public int PricePerGlass { get; private set; }

        public OrangeLemonadeRecipe()
        {
            Name = "Orange Lemonade";
            AllowedFruit = typeof(Orange);
            ConsumptionPerGlass = 1m;
            PricePerGlass = 9;
        }
    }
}