using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqPls
{
    public class BreadOrderingSystem
    {
        private IProductService productService;
        private IOrderService orderService;
        private List<string> orders = new List<string>();
        public BreadOrderingSystem(IProductService productService)
        {
            this.productService = productService;
        }

        public BreadOrderingSystem(IProductService productService, IOrderService orderService)
        {
            this.productService = productService;
            this.orderService = orderService;
        }

        public void PlaceOrder(string firstName, string lastName, string phoneNumber, string ProductIndex)
        {
            string orderDetails = $"{firstName} {lastName}, Tel: {phoneNumber}, Produkt: {ProductIndex}";
            orders.Add(orderDetails);
            orderService.AddNewOrder(firstName, lastName, phoneNumber, ProductIndex);

            Console.WriteLine($"\nZamówienie zapisane: {orderDetails}\nMożna odebrać swoje zamówienie w naszej piekarni. \nLokalizacja: Poznań, ul. Marca Pola 12,druga klatka od podwórka");
        }

        public void ChangeOrder()
        {
            Console.WriteLine("\nLista zamówień:");

            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {orders[i]}");
            }

            Console.Write("\nWybierz numer zamówienia do edycji: ");
            int orderIndex;

            while (!int.TryParse(Console.ReadLine(), out orderIndex) || orderIndex < 1 || orderIndex > orders.Count)
            {
                Console.WriteLine("Nieprawidłowy numer zamówienia. Spróbuj ponownie.");
                Console.Write("\nWybierz numer zamówienia do edycji: ");
            }

            var availableProducts = productService.GetAvailableProducts();
            Console.WriteLine("\nDostępne produkty:");

            for (int i = 0; i < availableProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableProducts[i]}");
            }
            string oldOrderDetails = orders[orderIndex - 1];

            Console.Write("\nPodaj nowy numer produktu: ");
            int productIndex;

            while (!int.TryParse(Console.ReadLine(), out productIndex) || productIndex < 1 || productIndex > productService.GetAvailableProducts().Count)
            {
                Console.WriteLine("Nieprawidłowy numer produktu. Spróbuj ponownie.");
                Console.Write("\nPodaj nowy numer produktu: ");
            }

            Console.Write("Podaj nowe imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nowe nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Podaj nowy numer telefonu: ");
            string phoneNumber = Console.ReadLine();

            string newOrderDetails = $"{firstName} {lastName}, Tel: {phoneNumber}, Produkt: {productService.GetAvailableProducts()[productIndex - 1]}";
            orders[orderIndex - 1] = newOrderDetails;

            Console.WriteLine("\nZamówienie zostało zmienione:");
            Console.WriteLine($"Stare zamówienie: {oldOrderDetails}");
            Console.WriteLine($"Nowe zamówienie: {newOrderDetails}");
        }

        public void DeleteOrder(int orderIndex)
        {
            if (orderIndex < 1 || orderIndex > orders.Count)
            {
                Console.WriteLine("Nieprawidłowy numer zamówienia. Spróbuj ponownie.");
                return;
            }

            string deletedOrderDetails = orders[orderIndex - 1];

            orders.RemoveAt(orderIndex - 1);

            Console.WriteLine("Zamówienie zostało usunięte:");
            Console.WriteLine($"\nUsunięte zamówienie: {deletedOrderDetails}");
        }

        public void CheckOrders()
        {
            Console.WriteLine("\nLista zamówień:");

            for (int i = 0; i < orders.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {orders[i]}");
            }
        }


        public void AddProduct()
        {
            Console.Write("\nPodaj nazwę nowego produktu: ");
            string newProduct = Console.ReadLine();

            while (productService.GetAvailableProducts().Contains(newProduct))
            {
                Console.WriteLine($"Produkt o nazwie '{newProduct}' już istnieje. Podaj inną nazwę.");
                Console.Write("Podaj nazwę nowego produktu: ");
                newProduct = Console.ReadLine();
            }

            productService.AddNewProduct(newProduct);
            Console.WriteLine($"Dodano nowy produkt: {newProduct}");
        }

        public void CheckProducts()
        {
            var availableProducts = productService.GetAvailableProducts();
            Console.WriteLine("\nDostępne produkty:");
            foreach (var product in availableProducts)
            {
                Console.WriteLine(product);
            }
        }
    }
}
