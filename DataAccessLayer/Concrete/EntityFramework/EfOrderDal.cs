using DataAccessLayer.Abstract;
using EntitiesLayer;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {

    }
}
