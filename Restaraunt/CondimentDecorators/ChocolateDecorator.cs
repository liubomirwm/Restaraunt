using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class ChocolateDecorator : Decorator
    {
        public ChocolateDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With chocolate";

        public override decimal Price => base.Price;
    }
}
