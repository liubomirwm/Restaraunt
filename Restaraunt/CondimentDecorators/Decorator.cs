using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    public class Decorator : Product
    {
        Product product;

        public Decorator(Product product) : base("Decorator", 0, null)
        {
            this.product = product;
        }

        public override string Name
        {
            get
            {
                return this.product.Name;
            }
        }

        public override decimal Price
        {
            get
            {
                return this.product.Price;
            }
        }
    }
}
