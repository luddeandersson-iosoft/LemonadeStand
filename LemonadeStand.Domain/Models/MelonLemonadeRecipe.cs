using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Domain.Models
{
    public class MelonLemonadeRecipe : IRecipe
    {
        public string Name { get; private set; }

        public Type AllowedFruit { get; private set; }

        public decimal ConsumptionPerGlass { get; private set; }

        public int PricePerGlass { get; private set; }

        public MelonLemonadeRecipe()
        {
            Name = "Melon Lemonade";
            AllowedFruit = typeof(Melon);
            ConsumptionPerGlass = 0.5m;
            PricePerGlass = 12;
        }
    }
}