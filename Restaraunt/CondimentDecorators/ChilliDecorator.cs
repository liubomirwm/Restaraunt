using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    class ChilliDecorator : Decorator
    {
        public ChilliDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With Chilli";
        public override decimal Price => base.Price + 0.10m;
    }
}
