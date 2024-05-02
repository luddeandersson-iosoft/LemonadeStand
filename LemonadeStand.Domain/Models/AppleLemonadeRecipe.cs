using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Domain.Models
{
    public class AppleLemonadeRecipe : IRecipe
    {
        public string Name { get; private set; }

        public Type AllowedFruit { get; private set; }

        public decimal ConsumptionPerGlass { get; private set; }

        public int PricePerGlass { get; private set; }

        public AppleLemonadeRecipe()
        {
            Name = "Apple Lemonade";
            AllowedFruit = typeof(Apple);
            ConsumptionPerGlass = 2.5m;
            PricePerGlass = 10;
        }
    }
}