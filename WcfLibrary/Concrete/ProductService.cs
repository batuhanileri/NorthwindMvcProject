using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntitiesLayer;
using NorthwindInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfLibrary.Concrete
{
    public class ProductService : IProductService
    {
        private ProductManager _productManager = new ProductManager(new EfProductDal());
        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);

        }
        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }

        public Product GetById(int productId)
        {
            return _productManager.GetById(productId);

        }
    }
}
