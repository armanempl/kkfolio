using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MoqPls
{
    class Program
    {
        public void Main()
        {
            List<string> initialProducts = ProductLoader.LoadProductsFromFile("..\\Products.txt");

            var productService = new ProductService(initialProducts);
            var breadOrderingSystem = new BreadOrderingSystem(productService);

            while (true)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("1. Złóż zamówienie");
                Console.WriteLine("2. Zmień zamówienie");
                Console.WriteLine("3. Usuń zamówienie");
                Console.WriteLine("4. Sprawdź dodane zamówienia");
                Console.WriteLine("5. Dodaj nowy produkt");
                Console.WriteLine("6. Sprawdź listę produktów");
                Console.WriteLine("0. Wyjście");

                Console.Write("Wybierz opcję: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var availableProducts = productService.GetAvailableProducts();

                        Console.Write("Wybierz numer produktu: ");
                        int productIndex;

                        while (!int.TryParse(Console.ReadLine(), out productIndex) || productIndex < 1 || productIndex > availableProducts.Count)
                        {
                            Console.WriteLine("Nieprawidłowy numer produktu. Spróbuj ponownie.");
                            Console.Write("\nWybierz numer produktu: ");
                        }


                        Console.Write("Podaj imię: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Podaj nazwisko: ");
                        string lastName = Console.ReadLine();

                        string phoneNumber;
                        bool validPhoneNumber = false;

                        do
                        {
                            Console.Write("Podaj numer telefonu: ");
                            phoneNumber = Console.ReadLine();

                            if (phoneNumber.Length == 9)
                            {
                                validPhoneNumber = true;
                            }
                            else
                            {
                                Console.WriteLine("Nieprawidłowa długość numeru telefonu. Numer powinien składać się z 9 cyfr.");
                            }

                        } while (!validPhoneNumber);

                        breadOrderingSystem.PlaceOrder(firstName, lastName, phoneNumber, availableProducts[productIndex - 1]);
                        break;
                    case "2":

                        breadOrderingSystem.ChangeOrder();
                        break;
                    case "3":
                        Console.Write("\nWybierz numer zamówienia do usunięcia: ");
                        int orderIndex;

                        while (!int.TryParse(Console.ReadLine(), out orderIndex))
                        {
                            Console.WriteLine("Nieprawidłowy numer zamówienia. Spróbuj ponownie.");
                            Console.Write("\nWybierz numer zamówienia do usunięcia: ");
                        }

                        breadOrderingSystem.DeleteOrder(orderIndex);
                        break;
                    case "4":
                        breadOrderingSystem.CheckOrders();
                        break;
                    case "5":
                        
                        breadOrderingSystem.AddProduct();
                        break;
                    case "6":
                        breadOrderingSystem.CheckProducts();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }

    }


}
