using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class OreoDecorator : Decorator
    {
        public OreoDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With Oreo";

        public override decimal Price => base.Price;
    }
}
