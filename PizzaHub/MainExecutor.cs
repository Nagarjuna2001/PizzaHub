using PizzaHub.Component;
using System;

namespace PizzaHub
{
    public class MainExecutor
    {
        static void Main(string[] args)
        {
            IOrder order = new OrderFactory();
            AbstractPizza pizzaTypeOrderedByCustomer = null;
            
            string pizzaTypeEnteredByCustomer;
            bool pizzaTypeExceptionOccured;
            Console.WriteLine("Please enter the pizza which you want to order :");

            do
            {
                pizzaTypeEnteredByCustomer = Console.ReadLine();
                pizzaTypeExceptionOccured = false;
                try
                {
                    pizzaTypeOrderedByCustomer = order.GetPizzaType(pizzaTypeEnteredByCustomer);
                }
                catch (ArgumentException ex)
                {
                    pizzaTypeExceptionOccured = true;
                    Console.WriteLine(ex.Message);
                }
            } while (pizzaTypeExceptionOccured);
            

            Console.WriteLine("Please provide any toppings of your choice: ");

            string ToppingTypeEnteredByCustomer;
            bool exceptionOccured;

            do
            {
                ToppingTypeEnteredByCustomer = Console.ReadLine();
                exceptionOccured = false;
                try
                {
                    pizzaTypeOrderedByCustomer = order.GetToppingOptedByUser(ToppingTypeEnteredByCustomer, pizzaTypeOrderedByCustomer);
                }
                catch (ArgumentException ex)
                {
                    exceptionOccured = true;
                    Console.WriteLine(ex.Message);
                }
            } while (exceptionOccured);


            Console.WriteLine(pizzaTypeOrderedByCustomer.GetDescription());
            Console.WriteLine(pizzaTypeOrderedByCustomer.GetPrice());
/*
            //Code to buy one type of pizza.i.e.Chicken pizza and to add toppings to it dynamically by wrapping the chicken pizza object
            //with the Bacon and Cheese Wrappers.
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

            Console.WriteLine("Price of pepperoni pizza with toppings extra Cheese and Green pepper : " + addGreenPepperToPepperoniPizza.GetPrice());*/
        }
    }
}
