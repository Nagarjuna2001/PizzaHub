using PizzaHub.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaHub
{
    public class OrderFactory : IOrder
    {
        public OrderFactory()
        {

        }

        public AbstractPizza GetPizzaType(string customerEnteredPizzaType)
        {
            if (customerEnteredPizzaType.ToLower().Equals("chicken"))
            {
                return new ChickenPizza();
            }
            else if (customerEnteredPizzaType.ToLower().Equals("flatbread"))
            {
                return new FlatBreadPizza();
            }
            else if (customerEnteredPizzaType.ToLower().Equals("pepperoni"))
            {
                return new PepperoniPizza();
            }
            else
                throw new ArgumentException("Please select a valid and available type");
        }

        public AbstractPizza GetToppingOptedByUser(string customerEnteredToppingType,AbstractPizza pizzaType)
        {
            if(customerEnteredToppingType.ToLower().Equals("bacon"))
            {
                return new Bacon(pizzaType);
            }
            else if(customerEnteredToppingType.ToLower().Equals("extracheese"))
            {
                return new ExtraCheese(pizzaType);
            }
            else if (customerEnteredToppingType.ToLower().Equals("greenpepper")) 
            {
                return new GreenPepper(pizzaType);
            }
            else
                throw new ArgumentException("Please select a valid topping");
        }
    }
}
