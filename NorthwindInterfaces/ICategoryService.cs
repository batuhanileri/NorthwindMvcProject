using EntitiesLayer;
using System.Collections.Generic;
using System.ServiceModel;

namespace NorthwindInterfaces
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAll();

        [OperationContract]
        Category GetById(int categoryId);

        [OperationContract]
        void Add(Category category);
        [OperationContract]
        void Delete(int categoryId);

        [OperationContract]
        void Update(Category category);

    }
}
