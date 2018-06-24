using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products.Drinks
{
    public class Retsina : Drink
    {
        static List<CondimentButton> retsinaCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add coke", typeof(CokeDecorator)),
            new CondimentButton("Add sprite", typeof(SpriteDecorator))
        };

        public Retsina() : base("Retsina", 14m, retsinaCondimentButtons)
        {
        }
    }
}
