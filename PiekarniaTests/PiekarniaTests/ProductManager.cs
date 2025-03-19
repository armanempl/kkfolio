using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiekarniaTests
{
    public class Product : IProduct
    {
        public string Name { get; }

        public Product(string name)
        {
            Name = name;
        }
    }

    public class Order : IOrder
    {
        public IProduct Product { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string PhoneNumber { get; }

        public Order(IProduct product, string firstName, string lastName, string phoneNumber)
        {
            Product = product;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }

    public class FileReader : IFileReader
    {
        public List<IProduct> ReadProducts(string filePath)
        {
            List<IProduct> products = new List<IProduct>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        products.Add(new Product(line.Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas odczytu pliku: {ex.Message}");
            }

            return products;
        }

        public List<IOrder> ReadOrders(string filePath)
        {
            List<IOrder> orders = new List<IOrder>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4)
                        {
                            IProduct product = new Product(parts[0].Trim());
                            string firstName = parts[1].Trim();
                            string lastName = parts[2].Trim();
                            string phoneNumber = parts[3].Trim();
                            orders.Add(new Order(product, firstName, lastName, phoneNumber));
                        }
                        else
                        {
                            Console.WriteLine($"Ignorowanie niepoprawnej linii: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas odczytu pliku: {ex.Message}");
            }

            return orders;
        }
    }

    public class FileWriter : IFileWriter
    {
        public void WriteOrders(List<IOrder> orders, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var order in orders)
                    {
                        writer.WriteLine($"{order.Product.Name},{order.FirstName},{order.LastName},{order.PhoneNumber}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd podczas zapisu pliku: {ex.Message}");
            }
        }
    }
}
