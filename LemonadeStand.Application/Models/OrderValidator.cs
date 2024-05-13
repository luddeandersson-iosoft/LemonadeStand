using FluentValidation;

namespace LemonadeStand.Application.Models
{
    public class OrderValidator : AbstractValidator<OrderModel>
    {
        public OrderValidator()
        {
            RuleFor(order => order.SelectedRecipe)
                .NotNull()
                .WithMessage("No recipe selected");

            RuleFor(order => order.Fruits)
                .NotEmpty()
                .WithMessage("No fruits added to the order");

            RuleFor(order => order.Fruits)
                .Must((order, fruits) => fruits.All(fruit => fruit.GetType() == order.SelectedRecipe.AllowedFruit))
                .WithMessage(order => $"One or more fruits are not allowed for the recipe {order.SelectedRecipe.Name}");

            RuleFor(order => order)
                .Must(order => order.SelectedRecipe != null && order.Fruits != null &&
                    order.Fruits.Count(f => f.GetType() == order.SelectedRecipe.AllowedFruit) >= order.SelectedRecipe.ConsumptionPerGlass * order.OrderedQuantity)
                .WithMessage("Not enough of the allowed fruit");

            RuleFor(order => order)
                .Must(order => order.SelectedRecipe != null &&
                    order.MoneyPaid >= order.SelectedRecipe.PricePerGlass * order.OrderedQuantity)
                .WithMessage("Customer payment not enough");

            RuleFor(order => order.MoneyPaid).GreaterThanOrEqualTo(0)
                .WithMessage("Payment can't be negative");
        }
    }
}
