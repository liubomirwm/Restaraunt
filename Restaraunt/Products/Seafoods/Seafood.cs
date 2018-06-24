using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Seafoods
{
    public class Seafood : Product
    {
        static List<CondimentButton> seafoodCondimentButtons = new List<CondimentButton>()
        {

        };

        public Seafood(string name, decimal price, List<CondimentButton> condimentButtons) : base(name, price, condimentButtons)
        {
            foreach (CondimentButton condimentButton in seafoodCondimentButtons)
            {
                base.CondimentButtons.Add(condimentButton);
            }
        }
    }
}
