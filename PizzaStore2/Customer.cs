using System;
namespace PizzaStore2
{
    public class customer
    {
        
            public void customerInfo()
            {
                Console.WriteLine("Dit navn?");
                string name = Console.ReadLine();

                Console.WriteLine("Din adresse");
                string adresse = Console.ReadLine();

                Console.WriteLine("dit telefonnummer?");
                string tlfnr = Console.ReadLine();

                Console.WriteLine("------------------------------");
                Console.WriteLine("Så dit navn er " + name);
                Console.WriteLine("adresse " + adresse);
                Console.WriteLine("telefonnummer " + tlfnr);
            }
        
    }
}
