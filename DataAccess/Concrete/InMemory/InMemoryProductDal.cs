using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IEntity
    {
        List<Product> _products; //Naming convention for global
        public InMemoryProductDal()
        {
            //Oracle, Sql, Postgres, MongoDb Simulation
            _products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Laptop", UnitPrice = 1000, UnitsInStock = 20},
                new Product{ProductId = 2, CategoryId = 1, ProductName = "Camera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 2, ProductName = "Keyboard", UnitPrice = 150, UnitsInStock = 50},
                new Product{ProductId = 4, CategoryId = 2, ProductName = "Speaker", UnitPrice = 240, UnitsInStock = 8},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Mouse", UnitPrice = 85, UnitsInStock = 1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;

            //    }
            //}
            //_products.Remove(productToDelete);

            //Instead we use the following (Linq):

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); //Similar to foreach
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllBCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        //Entity framework will handle all of this for us, this is just for learning the logic behind it.
        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
