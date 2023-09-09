using ProductOrderApp.Model;

namespace ProductOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Product product1 = new Product(1, "Flour", 45, 10);
            Product product2 = new Product(2, "Oil", 200, 20);

            LineItem lineItem1 = new LineItem(1, 2, product1);
            LineItem lineItem2 = new LineItem(2, 3, product2);

            List<LineItem> orderItems1 = new List<LineItem>();
            orderItems1.Add(lineItem1);
            orderItems1.Add(lineItem2);
            Order order1 = new Order(1, DateTime.Now, orderItems1);

            Product product3 = new Product(1, "Potato", 45, 10);
            Product product4 = new Product(2, "Tomato", 60, 20);
            LineItem lineItem3 = new LineItem(1, 2, product3);
            LineItem lineItem4 = new LineItem(2, 3, product4);
            List<LineItem> orderItems2 = new List<LineItem>();
            orderItems2.Add(lineItem3);
            orderItems2.Add(lineItem4);
            Order order2 = new Order(2, DateTime.Now, orderItems2);

            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);
            Customer customer = new Customer(1, "Rakesh", orders);

            Console.WriteLine("Customer Id: {0}", customer.Id);
            Console.WriteLine("Customer Name: {0}", customer.Name);

            Console.WriteLine("Order Count: {0}", customer.OrdersList.Count);

            for (int i = 0; i < customer.OrdersList.Count; i++)
            {

                Order order = customer.OrdersList[i];

                Console.WriteLine("Order No: {0}", i + 1);
                Console.WriteLine("Order Id: {0}", order.Id);
                Console.WriteLine("Order Date: {0}", order.Date);

                foreach (LineItem lineItem in order.Items)
                {

                    Console.Write($"{ lineItem.Id}\t");
                    Console.Write($"{lineItem.Product.Id}\t");
                    Console.Write($"{lineItem.Product.Name}\t");
                    Console.Write($"{lineItem.Quantity}\t");
                    Console.Write($"{lineItem.Product.Price}\t");
                    Console.Write($"{lineItem.Product.DiscountPercent}\t");
                    Console.Write($"{lineItem.Product.CalculateDiscountedPrice()}\t");
                    Console.WriteLine($"{lineItem.CalculateLineItemCost()}");

                }

                Console.WriteLine("Order Cost: {0}", order.CalculateOrderPrice());
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
    }
