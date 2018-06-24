using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class GinDecorator : Decorator
    {
        public GinDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With Gin";

        public override decimal Price => base.Price + 0.90m;
    }
}
