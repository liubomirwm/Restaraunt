using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class HummusDecorator : Decorator
    {
        public HummusDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With hummus";

        public override decimal Price => base.Price + 0.10m;
    }
}
