//
//

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAllByCategoryId(2)) //.GetByUnitPrice(50,100)
{
    Console.WriteLine(product.ProductName);
}


