using System;
namespace PizzaStore2
{
    public class Pizza
    {
        public int Number { get; private set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public Pizza(int number, string name, double price)
        {
            Number = number;
            Name = name;
            Price = price;
        }

        public Pizza()
        {
            Number = 0;
            Name = "";
            Price = 0;
        }

        public override string ToString()
        {
            return $"Number: {Number} Name: {Name} Price: {Price} kr.";

        }

        public void PizzaInfo()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Giv pizzaen et nummer: ");
            string number = Console.ReadLine();
            int iNumber;
            int.TryParse(number, out iNumber);
            Number = iNumber;

            Console.WriteLine("Giv pizzaen et navn: ");
            Name = Console.ReadLine();

            Console.WriteLine("Giv pizzaen en pris: ");
            string price = Console.ReadLine();
            int iPrice;
            int.TryParse(price, out iPrice);
            Price = iPrice;

            Console.WriteLine("Så nummeret er " + Number);
            Console.WriteLine("Navnet " + Name);
            Console.WriteLine("Prisen " + Price);

            
        }
    }
}
