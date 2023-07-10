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
        public int categoryId;

        public Category(int id, string categoryProduct, int categoryId)
        {
            this.id = id;
            this.categoryProduct = categoryProduct;
            this.categoryId = categoryId;
        }
    }
}
