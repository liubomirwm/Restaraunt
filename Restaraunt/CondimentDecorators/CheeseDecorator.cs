using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class CheeseDecorator : Decorator
    {
        public CheeseDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With cheese";

        public override decimal Price => base.Price;
    }
}
