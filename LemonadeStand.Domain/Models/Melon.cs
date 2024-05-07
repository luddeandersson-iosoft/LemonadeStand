using LemonadeStand.Domain.Interfaces;

namespace LemonadeStand.Domain.Models
{
    public class Melon : IFruit
    {
        public string Name { get; private set; }
        public Melon()
        {
            Name = "Melon";
        }

    }
}
