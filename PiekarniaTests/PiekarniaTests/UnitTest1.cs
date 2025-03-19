using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace PiekarniaTests
{
    public class OrderSavingTests
    {
        private const string TestOrdersFilePath = "../../../TestOrders.txt";


        [Fact]
        public void CreateAndWriteOrderToFile_IfSuccess()
        {
            try
            {
                var products = new List<IProduct>
            {
                new Product("Chleb"),
                new Product("Bu³ki"),
                new Product("P¹czek")
            };

                var orders = new List<IOrder>();
                var fileWriter = new FileWriter();
                OrderManager.AddNewOrder(orders, products[2], "Adam", "Mada", "555555555");
                fileWriter.WriteOrders(orders, TestOrdersFilePath);
                Assert.Single(orders);
                Assert.True(File.Exists(TestOrdersFilePath));


            }
            finally
            {
                if (File.Exists(TestOrdersFilePath))
                {
                    File.Delete(TestOrdersFilePath);
                    Console.WriteLine($"Deleted test file: {TestOrdersFilePath}");
                }
            }
        }


    }


    public class ProductsSaveTests
    {
        private const string TestProductsFilePath = "../../../TestProducts.txt";
        [Fact]
        public void ReadProductsFromFile_IfSuccess()
        {
            if (File.Exists(TestProductsFilePath))
            {
                File.Delete(TestProductsFilePath);
                Console.WriteLine($"Deleted test file: {TestProductsFilePath}");
            }
            var newProducts = new List<string> { "Bulki", "Drozdzowki", "Chalki" };
            WriteProductsToFile(newProducts, TestProductsFilePath);
            var reader = new FileReader();
            List<IProduct> products = reader.ReadProducts(TestProductsFilePath);
            List<String> productStrings = products.Select(product => product.Name).ToList();

            // Assert
            Assert.NotNull(products);
            Assert.Equal(3, products.Count);
            Assert.Contains("Bulki", productStrings);
            Assert.Contains("Drozdzowki", productStrings);
            Assert.Contains("Chalki", productStrings);



        }


        [Fact]
        public void WriteProductsToFile_Success()
        {
            // Arrange
            var newProducts = new List<string> { "Pumpernikiel", "Rogaliki", "Chleb pszenny" };

            // Act

            WriteProductsToFile(newProducts, TestProductsFilePath);

            // Assert
            var reader2 = new FileReader();
            List<IProduct> products = reader2.ReadProducts(TestProductsFilePath);
            List<String> productStrings = products.Select(product => product.Name).ToList();
            Assert.NotNull(products);
            Assert.Equal(6, products.Count); // 3 existing + 3 new

            Assert.Contains("Bulki", productStrings);
            Assert.Contains("Drozdzowki", productStrings);
            Assert.Contains("Chalki", productStrings);
            Assert.Contains("Pumpernikiel", productStrings);
            Assert.Contains("Rogaliki", productStrings);
            Assert.Contains("Chleb pszenny", productStrings);
        }

        private static void WriteProductsToFile(List<string> products, string filePath)
        {
            File.AppendAllLines(filePath, products);
        }



    }

}