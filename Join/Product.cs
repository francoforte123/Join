using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class Product
    {
        public int id;
        public string nameProduct;
        public int categoryId;

        public Product(int id, string nameProduct, int categoryId)
        {
            this.id = id;
            this.nameProduct = nameProduct;
            this.categoryId = categoryId;
        }
    }
}
