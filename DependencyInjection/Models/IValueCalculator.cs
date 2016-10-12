using System.Collections.Generic;

namespace DependencyInjection.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}