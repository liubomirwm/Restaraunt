using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Soups
{
    public class Soup : Product
    {
        static List<CondimentButton> soupsCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add chilli", typeof(ChilliDecorator)),
            new CondimentButton("Add vinegar", typeof(VinegarDecorator)),
            new CondimentButton("Add olive oil", typeof(OliveOilDecorator)),
            new CondimentButton("Add salt", typeof(SaltDecorator))
        };

        public Soup(string name, decimal price, List<CondimentButton> condimentButtons) : base(name, price, soupsCondimentButtons)
        {
            foreach (CondimentButton condimentButton in soupsCondimentButtons)
            {
                base.CondimentButtons.Add(condimentButton);
            }
        }
    }
}
