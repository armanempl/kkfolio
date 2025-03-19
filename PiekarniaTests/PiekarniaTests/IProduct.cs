using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiekarniaTests
{
    public interface IProduct
    {
        string Name { get; }
    }

    public interface IOrder
    {
        IProduct Product { get; }
        string FirstName { get; }
        string LastName { get; }
        string PhoneNumber { get; }
    }

    public interface IFileReader
    {
        List<IProduct> ReadProducts(string filePath);
        List<IOrder> ReadOrders(string filePath);
    }

    public interface IFileWriter
    {
        void WriteOrders(List<IOrder> orders, string filePath);
    }
}
