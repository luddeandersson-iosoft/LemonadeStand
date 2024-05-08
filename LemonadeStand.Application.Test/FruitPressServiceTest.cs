using FluentAssertions;
using LemonadeStand.Application.Services;
using LemonadeStand.Domain.Interfaces;
using LemonadeStand.Domain.Models;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Test
{
    public class FruitPressServiceTest
    {
        private readonly FruitPressService _fruitPressService;
        private readonly Collection<IFruit> _fruits;

        public FruitPressServiceTest()
        {
            _fruitPressService = new FruitPressService();
            _fruits = new Collection<IFruit>();
        }

        [Fact]
        public void Produce_ShouldSucceed_WhenMoneyAndFruitsIsEnough()
        {
            // Arrange
            IRecipe recipe = new Recipe("Apple Lemonade", typeof(Apple), 2, 5);
            int orderedGlassQuantity = 10;
            int moneyPaid = 100;    

            for(int i = 0; i < 24; i++)
            {
                _fruits.Add(new Apple());
            }

            // Act
            var result = _fruitPressService.Produce(recipe, _fruits, moneyPaid, orderedGlassQuantity);

            // Assert
            result.Success.Should().BeTrue();
            result.Message.Should().Be("Successfully Produced Lemonade!");
            result.ChangeReturned.Should().Be(50);
            result.RemainingFruits.Should().Be(4);
        }


        [Theory]
        [InlineData(10, 125, true)]
        [InlineData(5, 75, true)]
        [InlineData(20, 200, true)]
        public void Produce_ShouldSucceed_MultipleParameters(int orderedGlassQuantity, int moneyPaid, bool successExpected)
        {
            // Arrange
            IRecipe recipe = new Recipe("Apple Lemonade", typeof(Apple), 2, 5);

            _fruits.Clear();
            for (int i = 0; i < 25; i++)
            {
                _fruits.Add(new Apple());
            }

            // Act
            var result = _fruitPressService.Produce(recipe, _fruits, moneyPaid, orderedGlassQuantity);

            // Assert
            result.Success.Should().Be(successExpected);
            if (successExpected)
            {
                result.Message.Should().Be("Successfully Produced Lemonade!");
                result.ChangeReturned.Should().Be(moneyPaid - recipe.PricePerGlass * orderedGlassQuantity);
                result.RemainingFruits.Should().Be(25 - recipe.ConsumptionPerGlass*orderedGlassQuantity);
            }
        }
    }
}
