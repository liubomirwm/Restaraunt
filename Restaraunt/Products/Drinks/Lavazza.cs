using Restaraunt.CondimentDecorators;
using Restaraunt.Products.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products
{
    public class Lavazza : Drink
    {
        static List<CondimentButton> lavazzaCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add sugar", typeof(SugarDecorator)),
            new CondimentButton("Add cream", typeof(CreamDecorator))
        };


        public Lavazza() : base("Lavazza", 2.02m, lavazzaCondimentButtons)
        {

        }
    }
}
