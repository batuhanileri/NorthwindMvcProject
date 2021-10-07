using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindInterfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int productId);
        void Add(Product product);
        void Delete(int productId);
        void Update(Product product);

    }
}
