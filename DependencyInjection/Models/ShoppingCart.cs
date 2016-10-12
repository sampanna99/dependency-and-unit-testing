using System.Collections.Generic;

namespace DependencyInjection.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(products);
        }

    }
}