using LemonadeStand.Domain.Interfaces;
using System.Collections.ObjectModel;

namespace LemonadeStand.Application
{
    public class FruitPressResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int GlassesProduced { get; set; }
        public decimal RemainingFruits { get; set; }
        public decimal ChangeReturned { get; set; }

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