using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class OrangeDecorator : Decorator
    {
        public OrangeDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With Orange";

        public override decimal Price => base.Price + 0.15m;
    }
}
