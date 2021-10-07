using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindInterfaces
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> GetAll();

        [OperationContract]
        Product GetById(int productId);

        [OperationContract]
        void Add(Product product);
        [OperationContract]
        void Delete(int productId);

        [OperationContract]
        void Update(Product product);

    }
}
