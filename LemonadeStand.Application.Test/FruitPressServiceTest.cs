using FluentAssertions;
using LemonadeStand.Application.Services;
using LemonadeStand.Domain.Interfaces;
using Moq;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Test
{
    public class FruitPressServiceTest
    {
        private readonly FruitPressService _fruitPressService;
        private readonly Mock<IRecipe> _mockRecipe;
        private readonly Collection<IFruit> _fruits;

        public FruitPressServiceTest()
        {
            _mockRecipe = new Mock<IRecipe>();
            _fruitPressService = new FruitPressService();
            _fruits = new Collection<IFruit>();
        }

        [Fact]
        public void Produce_ShouldSucceed_WhenMoneyAndFruitsIsEnough()
        {
            // Arrange
            int pricePerGlass = 5;
            int consumptionPerGlass = 2;
            int orderedGlassQuantity = 10;
            int moneyPaid = 100;
            _mockRecipe.Setup(r => r.PricePerGlass).Returns(pricePerGlass);
            _mockRecipe.Setup(r => r.ConsumptionPerGlass).Returns(consumptionPerGlass);

            for(int i = 0; i < 24; i++)
            {
                _fruits.Add(new Mock<IFruit>().Object);
            }

            // Act
            var result = _fruitPressService.Produce(_mockRecipe.Object, _fruits, moneyPaid, orderedGlassQuantity);

            // Assert
            result.Success.Should().BeTrue();
            result.Message.Should().Be("Successfully Produced Lemonade!");
            result.ChangeReturned.Should().Be(50);
            result.RemainingFruits.Should().Be(4);
        }
    }
}
