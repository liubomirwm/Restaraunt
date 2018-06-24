using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class CapersDecorator : Decorator
    {
        public CapersDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With capers";

        public override decimal Price => base.Price + 0.30m;
    }
}
