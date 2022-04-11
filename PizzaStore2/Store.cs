using System;
namespace PizzaStore2
{
    public class Store
    {

        private const double _tax = 1.25;
        private const double _delivery = 40;
        // private static int orderNum = 1;

        //Mine pizzaer
        public static Pizza p1 = new Pizza(1, "VLB pezza", 76);
        public static Pizza p2 = new Pizza(2, "Cilek pezza", 69);

        public static customer c1 = new customer();
        public static customer c2 = new customer();

        public void Start()
        {
            // Test();
            UserDialog();
        }

        public void Test()
        {
            MenuCatalog menuCat = new MenuCatalog();

            //CreatePizza
            menuCat.CreatePizza(p1);
            menuCat.CreatePizza(p2);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Pizza Created:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            //ReadingPizza
            Console.WriteLine("------------------------------");
            Console.WriteLine("Reading pizzas:");
            Console.WriteLine(menuCat.ReadPizza(1));
            Console.WriteLine("------------------------------");


            //UpdatingPizza
            Pizza updatedPizza = new Pizza(p1.Number, "Updated", 99);
            menuCat.UpdatePizza(updatedPizza);
            Console.WriteLine("Updated pizza:");
            Console.WriteLine(menuCat.ReadPizza(1));
            Console.WriteLine("------------------------------");

            //DeletePizza
            Console.WriteLine($"Pizza number {p1.Number} is deleted");
            menuCat.DeletePizza(p1);
            Console.WriteLine("------------------------------");

            Console.WriteLine("Printing menu:");
            menuCat.PrintMenu();
            Console.WriteLine("------------------------------");

            try
            {
                Console.WriteLine(menuCat.ReadPizza(1));
                Console.WriteLine(menuCat.ReadPizza(2));
            }
            catch
            {
                Console.WriteLine("Pizza not found");
            }

            menuCat.PrintMenu();

            Pizza foundpizza = menuCat.SearchPizza("VLB");
            Console.WriteLine(foundpizza);
        }

        public void UserDialog()
        {
            bool exit = false;
            MenuCatalog menuCat = new MenuCatalog();
            menuCat.CreatePizza(p1);
            menuCat.CreatePizza(p2);

            while (!exit)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Skriv nummeret på dit valg:");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Vælg Pizza 1");
                Console.WriteLine("2. Vælg Pizza 2");
                Console.WriteLine("3. Test");
                Console.WriteLine("4. Afslut");
                Console.WriteLine("5. Opret pizza");


                static void PrintInfo(Pizza pizza)
                {
                    Console.WriteLine($"{pizza.Name} er din bestilling.");
                    Console.WriteLine($"Ordre nr. {pizza.Number}");
                    Console.WriteLine($"Pris: {(pizza.Price * _tax) + _delivery} DKK");
                }

                switch (Console.ReadLine())
                {
                    case "1":
                        PrintInfo(Store.p1);
                        Store.c1.customerInfo();
                        break;
                    case "2":
                        PrintInfo(Store.p2);
                        Store.c2.customerInfo();
                        break;
                    case "3":
                        Test();
                        return;
                    case "4":
                        exit = true;
                        return;
                    case "5":
                        Pizza p = new Pizza();
                        p.PizzaInfo();
                        menuCat.CreatePizza(p);
                        menuCat.PrintMenu();
                        return;
                    default:
                        Console.WriteLine("Findes ikke" + "\nPrøv igen");
                        continue;

                }

            }

        }



    }
}
