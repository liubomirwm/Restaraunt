using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class TonicDecorator : Decorator
    {
        public TonicDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With tonic";

        public override decimal Price => base.Price + 0.65m;
    }
}
