using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Pastas
{
    public class Pasta : Product
    {
        List<CondimentButton> pastasCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add pesto", typeof(PestoDecorator)),
            new CondimentButton("Add zucchini", typeof(ZucchiniDecorator)),
            new CondimentButton("Add cheese", typeof(CheeseDecorator))
        };

        public Pasta(string name, decimal price, List<CondimentButton> condimentButtons) : base(name, price, condimentButtons)
        {
            foreach (CondimentButton condimentButton in this.pastasCondimentButtons)
            {
                base.CondimentButtons.Add(condimentButton);
            }
        }
    }
}
