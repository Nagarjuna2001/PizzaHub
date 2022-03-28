using PizzaHub.Component;
using PizzaHub.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaHub
{
    public class ExtraCheese : PizzaDecorator
    {

        public ExtraCheese(AbstractPizza pizza) : base(pizza)
        {

        }
        public override string GetDescription()
        {
            return PizzaOptedByCustomer.GetDescription() + " with extra Cheese";
        }

        public override int GetPrice()
        {
            return PizzaOptedByCustomer.GetPrice() + 40;
        }
    }
}
