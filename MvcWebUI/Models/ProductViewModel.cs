using EntitiesLayer;
using PagedList;
using System.Collections.Generic;

namespace MvcWebUI
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public object PagingInfo { get; set; }
    }
}