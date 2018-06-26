using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationProgramming.entity
{
    class Product
    {
        public string productId { get; set; }
        public string productName { get; set; }
        public string price { get; set; }

        public Product()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
