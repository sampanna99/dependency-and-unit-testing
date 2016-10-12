namespace DependencyInjection.Models
{
    public class Discount : IDiscountHelper
    {

        public decimal DiscountSize;
        public Discount(decimal discountParam)
        {
            DiscountSize = discountParam;
        }


        public decimal ApplyDiscount(decimal totalparam)
        {
            return (totalparam - (DiscountSize / 100m * totalparam));
        }

    }
}