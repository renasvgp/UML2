using System;
namespace PizzaStore2
{
    public class Order
    {
        private const double _tax = 1.25;
        private const double _delivery = 40;
        private static int orderNum = 1;

        public Order()
        {
        }

        private static void PrintInfo(Pizza pizza)
        {
            Console.WriteLine($"{pizza.Name} er din bestilling.");
            Console.WriteLine("Order nr." + orderNum++);
            Console.WriteLine($"Price: {(pizza.Price * _tax) + _delivery} DKK");
        }

    }
}
