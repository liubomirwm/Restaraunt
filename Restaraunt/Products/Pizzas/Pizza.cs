using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Pizzas
{
    public class Pizza : Product
    {
        static List<CondimentButton> pizzaCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add ketchup", typeof(KetchupDecorator)),
            new CondimentButton("Add pesto", typeof(PestoDecorator)),
            new CondimentButton("Add chilli", typeof(ChilliDecorator)),
            new CondimentButton("Add salsa", typeof(SalsaDecorator)),
            new CondimentButton("Add hummus", typeof(HummusDecorator))
        };

        public Pizza(string name, decimal price, List<CondimentButton> condimentButtons) : base(name, price, pizzaCondimentButtons)
        {
            foreach (CondimentButton condimentButton in pizzaCondimentButtons)
            {
                base.CondimentButtons.Add(condimentButton);
            }
        }
    }
}
