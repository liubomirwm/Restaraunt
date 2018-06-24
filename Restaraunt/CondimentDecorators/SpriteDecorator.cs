using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class SpriteDecorator : Decorator
    {
        public SpriteDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With sprite";

        public override decimal Price => base.Price + 0.40m;
    }
}
