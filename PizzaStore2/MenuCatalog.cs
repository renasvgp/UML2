using System;
using System.Collections.Generic;
using System.Text;
namespace PizzaStore2
{
    class MenuCatalog
    {
        Dictionary<int, Pizza> pizzas;

        public MenuCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
        }

        public void CreatePizza(Pizza pizza)
        {
            pizzas.Add(pizza.Number, pizza);
        }

        public Pizza ReadPizza(int number)
        {
            return pizzas[number];
        }

        public void UpdatePizza(Pizza pizza)
        {
            Pizza p = ReadPizza(pizza.Number);
            p.Name = pizza.Name;
            p.Price = pizza.Price;

        }

        public void DeletePizza(Pizza pizza)
        {
            pizzas.Remove(pizza.Number);
        }

        public Pizza SearchPizza(string searchCrit)
        {
            foreach(Pizza p in pizzas.Values)
            {
                if (p.Name.StartsWith(searchCrit))
                {
                    return p;
                }
            }

            return null;
        }

        public void PrintMenu()
        {
            foreach(var p in pizzas)
            {
                Console.WriteLine($"Pizza nummer {p.Value.Number}: {p.Value.Name}. Prisen er {p.Value.Price} Kr. ");
            }
        }

        
    }
}