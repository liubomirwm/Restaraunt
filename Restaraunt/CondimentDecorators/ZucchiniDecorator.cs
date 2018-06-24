using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class ZucchiniDecorator : Decorator
    {
        public ZucchiniDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With Zucchini";

        public override decimal Price => base.Price + 0.05m;
    }
}
