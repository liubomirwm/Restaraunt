using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class SaltDecorator : Decorator
    {
        public SaltDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With salt";

        public override decimal Price => base.Price;
    }
}
