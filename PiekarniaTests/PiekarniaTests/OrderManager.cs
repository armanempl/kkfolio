using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiekarniaTests
{
        public static class OrderManager
        {
        public static void AddNewOrder(List<IOrder> orders, IProduct prodSel, string imie, string nazwisko, string numer)
            {
            orders.Add(new Order(prodSel, imie, nazwisko, numer));
        }

            public static void DisplayProductList(List<IProduct> products)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name}");
                }
            }

            public static void DisplayOrderList(List<IOrder> orders)
            {
                Console.WriteLine("Lista zamówień: ");
                foreach (var order in orders)
                {
                    Console.WriteLine($"Produkt: {order.Product.Name}, Imię: {order.FirstName}, Nazwisko: {order.LastName}, Telefon: {order.PhoneNumber}");
                }
            }
        }
   }
