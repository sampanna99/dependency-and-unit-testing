using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DependencyInjection.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;

        private static int counter = 0;

        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;

            Debug.WriteLine(string.Format("Instance {0} created", ++counter));
        }


        public decimal ValueProducts(IEnumerable<Product> products)
        {
            //return products.Sum(p => p.Price);
            return discounter.ApplyDiscount(products.Sum(p => p.Price));
        }
    }
}