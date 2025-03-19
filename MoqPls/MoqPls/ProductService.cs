using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPls
{
    using System.Collections.Generic;

public class ProductService : IProductService
{
    private List<string> availableProducts;

    public ProductService(List<string> initialProducts)
    {
        availableProducts = initialProducts ?? new List<string>();
    }

    public List<string> GetAvailableProducts()
    {
        return availableProducts;
    }

    public void AddNewProduct(string productName)
    {
        if (availableProducts.Contains(productName))
        {
            throw new InvalidOperationException($"Produkt o nazwie '{productName}' już istnieje. Podaj inną nazwę.");
        }

        availableProducts.Add(productName);
    }
}
}
