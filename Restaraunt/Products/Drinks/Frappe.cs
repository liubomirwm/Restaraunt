using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Drinks
{
    class Frappe : Drink
    {
        static List<CondimentButton> frappeCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add Oreo", typeof(OreoDecorator)),
            new CondimentButton("Add ice cream", typeof(IceCreamDecorator))
        };

        public Frappe() : base("Frappe", 2, frappeCondimentButtons)
        {
        }
    }
}
