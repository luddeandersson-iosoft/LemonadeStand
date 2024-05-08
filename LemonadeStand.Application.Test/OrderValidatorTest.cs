using FluentAssertions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FluentValidation.TestHelper;
using LemonadeStand.Application.Models;
namespace LemonadeStand.Application.Test
{
    public class OrderValidatorTest
    {
        private readonly OrderValidator _validator;

        public OrderValidatorTest()
        {
            _validator = new OrderValidator();
        }

        [Fact]
        public void Validate_ShouldHaveError_WhenNoRecipeSelected()
        {

        }

        [Fact]
        public void Validate_ShouldHaveError_WhenNoFruitsAdded()
        {

        }

        [Fact]
        public void Validate_ShouldHaveError_WhenDisallowedFruitsAreUsed()
        {

        }


        [Fact]
        public void Validate_ShouldHaveError_WhenNotEnoughAllowedFruits()
        {

        }

        [Fact]
        public void Validate_ShouldHaveError_WhenCustomerPaymentNotEnough()
        {

        }
    }
}