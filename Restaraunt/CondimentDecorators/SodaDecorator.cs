using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class SodaDecorator : Decorator
    {
        public SodaDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With soda";

        public override decimal Price => base.Price + 0.35m;
    }
}
