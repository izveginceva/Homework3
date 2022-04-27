using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Product
    {
        
        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Weight { get; private set; }

        public Product(double height, double width, double weight)
        {
            Height = height;
            Width = width;
            Weight = weight;
        }

        public Product CreateNewProduct(double productHeight)
        {
            Product myNewProduct = newProduct(productHeight);
            return myNewProduct;

        }
    }
}
