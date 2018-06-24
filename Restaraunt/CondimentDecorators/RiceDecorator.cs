using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class RiceDecorator : Decorator
    {
        public RiceDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With rice";

        public override decimal Price => base.Price + 0.30m;
    }
}
