using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Product
    {
        public Product()
        {
        }

        public Product(double height, double width, double weight)
        {
            Height = height;
            Width = width;
            Weight = weight;
        }
        public double Height { get;  }
        public double Width { get;  }
        public double Weight { get; }

        

          }
}
