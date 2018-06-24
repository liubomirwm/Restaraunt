using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class HoneyDecorator : Decorator
    {
        public HoneyDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With honey";

        public override decimal Price => base.Price + 0.25m;
    }
}
