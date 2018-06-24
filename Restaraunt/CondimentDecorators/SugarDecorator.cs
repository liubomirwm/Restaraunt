using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class SugarDecorator : Decorator
    {
        public SugarDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With Sugar";

        public override decimal Price => base.Price;
    }
}
