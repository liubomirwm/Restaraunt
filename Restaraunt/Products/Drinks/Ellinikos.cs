using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Drinks
{
    public class Ellinikos : Drink
    {
        static List<CondimentButton> ellinikosCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add sugar", typeof(SugarDecorator)),
            new CondimentButton("Add cream", typeof(CreamDecorator))
        };

        public Ellinikos() : base("Ellinikos", 2.45m, ellinikosCondimentButtons)
        {
        }
    }
}
