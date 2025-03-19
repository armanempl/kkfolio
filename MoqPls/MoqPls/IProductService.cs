using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPls
{
    public interface IProductService
    {
        List<string> GetAvailableProducts();
        void AddNewProduct(string productName);
    }
    public interface IOrderService
    {
        void AddNewOrder(string firstName, string lastName, string phoneNumber, string product);
    }
}
