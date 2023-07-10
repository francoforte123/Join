using Join;
List<Product> listOfProduct = new()
{
    new Product(1, "smartphne", 1),
    new Product(2, "computer", 2),
    new Product(3, "libro", 3),
};

List<Category> listOfCategory = new()
{
    new Category(1, "elettronica", 1),
    new Category(2, "informatica", 2),
    new Category(3, "lettura", 3),
};


var relationProductCategory = from product in listOfProduct
                              join category in listOfCategory
                              on product.categoryId equals category.categoryId
                              select new
                              {
                                  productName= product.nameProduct, categoryName= category.categoryProduct
                              };

foreach(var result in relationProductCategory)
{
    Console.WriteLine("prodotto: " + result.productName + ", categoria: " + result.categoryName);
}










