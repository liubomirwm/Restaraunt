using Restaraunt.Products.Seafoods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class GreekMussels : Seafood
    {
        static List<CondimentButton> greekMusselsCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add rice", typeof(RiceDecorator)),
            new CondimentButton("Add capers", typeof(CapersDecorator))
        };

        public GreekMussels() : base("Greek Mussels", 5.14m, greekMusselsCondimentButtons)
        {
        }
    }
}
