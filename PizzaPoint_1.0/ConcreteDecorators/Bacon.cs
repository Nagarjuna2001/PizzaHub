using PizzaHub.Component;
using PizzaHub.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaHub
{
    public class Bacon : PizzaDecorator
    {
        public Bacon(AbstractPizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return PizzaOptedByCustomer.GetDescription() + " with added Bacon";
        }
        public override int GetPrice()
        {
            return PizzaOptedByCustomer.GetPrice() + 50;
        }

    }
}
