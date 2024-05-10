using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Domain.Models
{
    public class Apple : IFruit
    {
        public string Name { get; } = "Apple";
    }
}