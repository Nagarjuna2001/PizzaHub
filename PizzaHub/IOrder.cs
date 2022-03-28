using PizzaHub.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaHub
{
    public interface IOrder
    {
        AbstractPizza GetPizzaType(string customerEnteredPizzaType);

        AbstractPizza GetToppingOptedByUser(string customerEnteredToppingType,AbstractPizza pizzaType);
    }
}
