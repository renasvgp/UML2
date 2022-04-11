using System;

namespace PizzaStore2
{
    class Program
    {
        public static Pizza p1 = new Pizza(1, "VLB pezza", 65);
        public static Pizza p2 = new Pizza(2, "Cilek pezza", 50);

        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen!");
            Console.WriteLine("Hvilken pizza vil du bestille?");
            Console.WriteLine("------------------------------");

            
            Console.WriteLine($"Pizza nummer 1: {p1.Name}");
            Console.WriteLine($"Pizza nummer 2: {p2.Name}");
           
            new Store().Start();
        }
    }
}
