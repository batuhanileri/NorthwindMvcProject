using EntitiesLayer;
using System.Collections.Generic;

namespace MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public object PagingInfo { get; set; }
    }
}