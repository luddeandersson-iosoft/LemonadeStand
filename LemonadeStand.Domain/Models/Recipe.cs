using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Domain.Models
{
    public class Recipe : IRecipe
    {
        public string Name { get; set; }
        public Type AllowedFruit { get; set; }
        public decimal ConsumptionPerGlass { get; set; }
        public int PricePerGlass { get; set; }

        public Recipe(string name, Type allowedFruit, decimal consumptionPerGlass, 
            int pricePerGlass)
        {
            Name = name;
            AllowedFruit = allowedFruit;
            ConsumptionPerGlass = consumptionPerGlass;
            PricePerGlass = pricePerGlass;
        }
    }
}
