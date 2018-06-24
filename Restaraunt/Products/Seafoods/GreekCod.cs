using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Seafoods
{
    public class GreekCod : Seafood
    {
        static List<CondimentButton> greekCodCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add rice", typeof(RiceDecorator)),
            new CondimentButton("Add capers", typeof(CapersDecorator))
        };

        public GreekCod() : base("Greek Cod", 4.18m, greekCodCondimentButtons)
        {
        }
    }
}
