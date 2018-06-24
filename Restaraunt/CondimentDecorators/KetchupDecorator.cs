using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class KetchupDecorator : Decorator
    {
        public KetchupDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With ketchup";

        public override decimal Price => base.Price;
    }
}
