using PizzaHub;
using PizzaHub.Component;
using System;

namespace PizzaPoint_1._0
{
    public class MainExecutor
    {
        static void Main(string[] args)
        {
            AbstractPizza orderChickenPizza = new ChickenPizza();
            Console.WriteLine("Price of chicken pizza without any toppings : " + orderChickenPizza.GetPrice());

            AbstractPizza addBaconToChickenPizza = new Bacon(orderChickenPizza);
            AbstractPizza addExtraCheeseToChickenPizza = new ExtraCheese(addBaconToChickenPizza);
            Console.WriteLine("Price of chicken pizza with toppings extra Cheese and Bacon : " + addExtraCheeseToChickenPizza.GetPrice());

            Console.WriteLine("\n");

            //Code to buy one type of pizza.i.e.Pepperoni pizza and to add toppings to it dynamically by wrapping the pepperoni pizza object
            //with the Extra Cheese and GreenPepper Wrappers.
            AbstractPizza orderPepperoniPizza = new PepperoniPizza();
            Console.WriteLine("Price of pepperoni pizza without any toppings : " + orderPepperoniPizza.GetPrice());

            AbstractPizza addExtraCheeseToPepperoniPizza = new ExtraCheese(orderPepperoniPizza);
            AbstractPizza addGreenPepperToPepperoniPizza = new GreenPepper(addExtraCheeseToPepperoniPizza);

            Console.WriteLine("Price of pepperoni pizza with toppings extra Cheese and Green pepper : " + addGreenPepperToPepperoniPizza.GetPrice());
        }
    }
}
