using PizzaHub.Component;
using PizzaHub.UserDefinedExceptions;
using System;

namespace PizzaHub
{
    public class MainExecutor
    {
        private static bool CheckUserChoiceIsValidOrNot(string choice)
        {
            
            if(choice.ToLower().Equals("y") || choice.ToLower().Equals("yes"))
            {
                return true;
            }
            else if(choice.ToLower().Equals("n") || choice.ToLower().Equals("no"))
            {
                return false;
            }
            else
            {
                throw new ArgumentException("Please select a valid option");
            }
        }
        private static bool GetInputForCustomerChoice()
        {
            string UserchoiceToAddTopping = "";
            bool proceedFurther = true;
            bool finalChoice = false; ;
            do
            {
                proceedFurther = true;
                try
                {
                    UserchoiceToAddTopping = Console.ReadLine();
                    finalChoice = CheckUserChoiceIsValidOrNot(UserchoiceToAddTopping);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    proceedFurther = false;
                }
            } while (!proceedFurther);
            return finalChoice;
        }
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
                catch (InvalidPizzaSelectedException ex)
                {
                    pizzaTypeExceptionOccured = true;
                    Console.WriteLine(ex.Message);
                }
            } while (pizzaTypeExceptionOccured);
            

            string ToppingTypeEnteredByCustomer;
            bool exceptionOccured;

           

            Console.WriteLine("Do you want to add toppings along with the pizza [Y | N] : ");

            while (GetInputForCustomerChoice()) 
            {
                Console.WriteLine("Please provide any topping of your choice: ");

                do
                {
                    ToppingTypeEnteredByCustomer = Console.ReadLine();
                    exceptionOccured = false;
                    try
                    {
                        pizzaTypeOrderedByCustomer = order.GetToppingOptedByUser(ToppingTypeEnteredByCustomer, pizzaTypeOrderedByCustomer);
                    }
                    catch (InvalidToppingSelectedException ex)
                    {
                        exceptionOccured = true;
                        Console.WriteLine(ex.Message);
                    }
                } while (exceptionOccured);
                
                Console.WriteLine("Do you want to add more  toppings [Y | N] : ");

            } 

            Console.WriteLine("Processing your order...");
            Console.WriteLine("\n Order Summary : \n");
            Console.WriteLine(pizzaTypeOrderedByCustomer.GetDescription());
            Console.WriteLine(pizzaTypeOrderedByCustomer.GetPrice());




            /*do
                        {
                            ToppingTypeEnteredByCustomer = Console.ReadLine();
                            exceptionOccured = false;
                            try
                            {
                                pizzaTypeOrderedByCustomer = order.GetToppingOptedByUser(ToppingTypeEnteredByCustomer, pizzaTypeOrderedByCustomer);
                            }
                            catch (InvalidToppingSelectedException ex)
                            {
                                exceptionOccured = true;
                                Console.WriteLine(ex.Message);
                                continue;
                            }
                            Console.WriteLine("Do you want to add more toppings [Y | N] : ");
                            string UserchoiceToAddTopping = Console.ReadLine();

                            if (CheckUserChoice(UserchoiceToAddTopping))
                            {
                                exceptionOccured = true;
                                Console.WriteLine("Please provide any topping of your choice: ");
                            }
                            else
                            {
                                Console.WriteLine("Processing your order...");
                            }
                        } while (exceptionOccured);*/



            /*
             * 
             *           

            //Code to buy one type of pizza.i.e.Chicken pizza and to add toppings to it dynamically by wrapping the chicken pizza object
            //with the Bacon and Cheese Wrappers.
            /*AbstractPizza orderChickenPizza = new ChickenPizza();
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
