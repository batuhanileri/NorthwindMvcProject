using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int ProductName { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
