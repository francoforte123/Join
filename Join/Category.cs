using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Category
    {
        public int id;
        public string categoryProduct;
        public int productId;

        public Category(int id, string categoryProduct, int productId)
        {
            this.id = id;
            this.categoryProduct = categoryProduct;
            this.productId = productId;
        }
    }
}
