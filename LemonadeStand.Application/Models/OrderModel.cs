using LemonadeStand.Domain.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace LemonadeStand.Application.Models
{
    public class OrderModel
    {
        public IRecipe? SelectedRecipe { get; set; }
        public Collection<IFruit> Fruits { get; set; } = new Collection<IFruit>();
        public int OrderedQuantity { get; set; }
        public int MoneyPaid { get; set; }
        

        public OrderModel() {}
    }
}
