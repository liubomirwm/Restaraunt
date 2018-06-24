using Restaraunt.CondimentDecorators;
using Restaraunt.Products.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products
{
    public class Campari : Drink
    {
        static List<CondimentButton> campariCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add soda", typeof(SodaDecorator)),
            new CondimentButton("Add orange", typeof(OrangeDecorator))
        };

        public Campari() : base("Campari", 4.44m, campariCondimentButtons)
        {

        }
    }
}
