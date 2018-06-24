using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Sweets
{
    public class Sweet : Product
    {
        List<CondimentButton> sweetsCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add honey", typeof(HoneyDecorator)),
            new CondimentButton("Add chocolate", typeof(ChocolateDecorator))
        };
        public Sweet(string name, decimal price, List<CondimentButton> condimentButtons) : base(name, price, condimentButtons)
        {
            if (this.sweetsCondimentButtons != null)
            {
                foreach (CondimentButton condimentButton in this.sweetsCondimentButtons)
                {
                    base.CondimentButtons.Add(condimentButton);
                }
            }
        }
    }
}
