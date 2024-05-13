using LemonadeStand.Domain.Interfaces;
using LemonadeStand.Domain.Models;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Models
{
    public class FruitFactory
    {
        public static Collection<IFruit> CreateFruitList(int apples, int melons, int oranges)
        {
            var fruits = new Collection<IFruit>();

            for(int i = 0; i < apples; i++)
            {
                fruits.Add(new Apple());
            }
            for(int i = 0; i < melons; i++)
            {
                fruits.Add(new Melon());
            }
            for(int i = 0;i < oranges; i++)
            {
                fruits.Add(new Orange());
            }
            return fruits;
        }
    }
}
