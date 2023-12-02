using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_Part3_HW3.Class
{
    // Define abstract class Factory
    public abstract class Factory
    {
        // Define abstract method CreateProduct
        public abstract IProduct CreateProduct();
    }
}
