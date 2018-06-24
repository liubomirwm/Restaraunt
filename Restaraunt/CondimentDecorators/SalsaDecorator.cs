using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class SalsaDecorator : Decorator
    {
        public SalsaDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With salsa";

        public override decimal Price => base.Price;
    }
}
