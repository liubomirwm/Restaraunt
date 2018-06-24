using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class VinegarDecorator : Decorator
    {
        public VinegarDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With vinegar";

        public override decimal Price => base.Price;
    }
}
