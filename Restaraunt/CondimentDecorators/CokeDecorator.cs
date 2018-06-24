using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class CokeDecorator : Decorator
    {
        public CokeDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With coke";

        public override decimal Price => base.Price + 0.40m;
    }
}
