using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class OliveOilDecorator : Decorator
    {
        public OliveOilDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With olive oil";

        public override decimal Price => base.Price;
    }
}
