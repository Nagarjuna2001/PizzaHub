using PizzaHub.Component;
using PizzaHub.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaHub
{
    public class GreenPepper : PizzaDecorator
    {
        public GreenPepper(AbstractPizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return PizzaOptedByCustomer.GetDescription() + " with added Green Pepper";
        }
        public override int GetPrice()
        {
            return PizzaOptedByCustomer.GetPrice() + 30;
        }
    }
}
