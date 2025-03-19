using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiekarniaTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string productsFilePath = "../../../Products.txt";
            string ordersFilePath = "../../../Orders.txt";

            IFileReader fileReader = new FileReader();
            IFileWriter fileWriter = new FileWriter();

            List<IProduct> products = fileReader.ReadProducts(productsFilePath);
            List<IOrder> orders = fileReader.ReadOrders(ordersFilePath);

            Console.WriteLine("Witaj w programie Piekarnia!");

            while (true)
            {
                Console.WriteLine("\nWybierz opcję:");
                Console.WriteLine("1. Dodaj nowe zamówienie");
                Console.WriteLine("2. Wyświetl listę zamówień");
                Console.WriteLine("3. Zapisz listę zamówień do pliku");
                Console.WriteLine("0. Zakończ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Dostępne produkty:");
                        OrderManager.DisplayProductList(products);

                        Console.Write("Wybierz numer produktu: ");
                        if (int.TryParse(Console.ReadLine(), out int selectedProductIndex) &&
                            selectedProductIndex >= 1 && selectedProductIndex <= products.Count)
                        {
                            IProduct selectedProduct = products[selectedProductIndex - 1];
                            Console.WriteLine($"Wybrano produkt: {selectedProduct.Name}");

                            Console.Write("Podaj imię: ");
                            string firstName = Console.ReadLine();

                            Console.Write("Podaj nazwisko: ");
                            string lastName = Console.ReadLine();

                            Console.Write("Podaj numer telefonu: ");
                            string phoneNumber = Console.ReadLine();

                            
                            Console.WriteLine("Zamówienie dodane!");
                            OrderManager.AddNewOrder(orders, selectedProduct, firstName, lastName, phoneNumber);
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy numer produktu.");
                        }
                       
                        break;

                    case "2":
                        OrderManager.DisplayOrderList(orders);
                        break;

                    case "3":
                        fileWriter.WriteOrders(orders, ordersFilePath);
                        Console.WriteLine("Lista zamówień zapisana do pliku.");
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Nieznana opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
