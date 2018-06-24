using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Drinks
{
    public class Drink : Product
    {
        List<CondimentButton> drinksCondimentButtons = new List<CondimentButton>()
        {
        };

        public Drink(string name, decimal price, List<CondimentButton> condimentButtons) : base(name, price, condimentButtons)
        {
            foreach (CondimentButton condimentButton in this.drinksCondimentButtons)
            {
                base.CondimentButtons.Add(condimentButton);
            }
        }
    }
}
