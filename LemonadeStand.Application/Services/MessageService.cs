namespace LemonadeStand.Application.Services
{
    public class MessageService
    {
        public string CreateOrderSuccessMessage(FruitPressResult result)
        {
            return $"Successfully processed order! Glasses Produced: {result.GlassesProduced}, Remaining Fruits: {result.RemainingFruits}, Change Returned: {result.ChangeReturned}";
        }

        public string CreateOrderFailureMessage(List<string> errors)
        {
            return "Validation failed: " + string.Join(", ", errors);
        }
    }
}
