using Restaraunt.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.Products
{
    public class Vermouth : Product
    {
        static List<CondimentButton> vermouthCondimentButtons = new List<CondimentButton>()
        {
            new CondimentButton("Add gin", typeof(GinDecorator)),
            new CondimentButton("Add tonic", typeof(TonicDecorator))

        };

        public Vermouth() : base("Vermouth", 3.00m, vermouthCondimentButtons)
        {

        }
    }
}
