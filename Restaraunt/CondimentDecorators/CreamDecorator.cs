using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class CreamDecorator : Decorator
    {
        public CreamDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With Cream";

        public override decimal Price => base.Price + 0.15m;
    }
}
