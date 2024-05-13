using FluentAssertions;
using LemonadeStand.Application.Services;
using LemonadeStand.Domain.Interfaces;
using LemonadeStand.Domain.Models;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application.Test
{
    public class FruitPressServiceTests
    {
        private readonly IRecipe recipe;
        private readonly Collection<IFruit> fruits;
        private readonly FruitPressService fruitPressService;

        public FruitPressServiceTests()
        {
            recipe = new Recipe("Apple Lemonade", typeof(Apple), 2, 5);
            fruits = new Collection<IFruit>(Enumerable.Repeat<IFruit>(new Apple(), 25).ToList());
            fruitPressService = new FruitPressService();
        }

        [Fact]
        public void Produce_ShouldReturnSuccess_WhenConditionsAreMet()
        {
            // Arrange
            int moneyPaid = 125;
            int orderedGlassQuantity = 10;

            // Act
            var result = fruitPressService.Produce(recipe, fruits, moneyPaid, orderedGlassQuantity);

            // Assert
            result.Success.Should().BeTrue();
        }

        [Fact]
        public void Produce_ShouldReturnCorrectMessage_WhenSuccessful()
        {
            // Arrange
            int moneyPaid = 125;
            int orderedGlassQuantity = 10;

            // Act
            var result = fruitPressService.Produce(recipe, fruits, moneyPaid, orderedGlassQuantity);

            // Assert
            result.Message.Should().Be("Successfully Produced Lemonade!");
        }

        [Fact]
        public void Produce_ShouldReturnCorrectChange_WhenSuccessful()
        {
            // Arrange
            int moneyPaid = 125;
            int orderedGlassQuantity = 10;

            // Act
            var result = fruitPressService.Produce(recipe, fruits, moneyPaid, orderedGlassQuantity);

            // Assert
            result.ChangeReturned.Should().Be(75);
        }

        [Fact]
        public void Produce_ShouldReturnCorrectRemainingFruits_WhenSuccessful()
        {
            // Arrange
            int moneyPaid = 125;
            int orderedGlassQuantity = 10;

            // Act
            var result = fruitPressService.Produce(recipe, fruits, moneyPaid, orderedGlassQuantity);

            // Assert
            result.RemainingFruits.Should().Be(5);
        }
    }

}
