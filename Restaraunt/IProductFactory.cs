﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt
{
    public interface IProductFactory
    {
        Product GetProduct(string selectedProduct);
    }
}
