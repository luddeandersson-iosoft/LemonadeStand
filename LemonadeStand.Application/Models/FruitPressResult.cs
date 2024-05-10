using LemonadeStand.Domain.Interfaces;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application
{
    public class FruitPressResult
    {
        public bool Success { get; }
        public string Message { get; }
        public int GlassesProduced { get; }
        public decimal RemainingFruits { get; }
        public decimal ChangeReturned { get; }

        public FruitPressResult(bool success, string message, int glassesProduced, 
            decimal remainingFruits, decimal changeReturned = 0) 
        {
            Success = success;
            Message = message;
            GlassesProduced = glassesProduced;
            RemainingFruits = remainingFruits;
            ChangeReturned = changeReturned;
        }
    }
}