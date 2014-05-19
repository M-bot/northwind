using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
        public int StatusID { get; set; }
        public DateTime DateAllocated { get; set; }
        public int PurchaseOrderID { get; set; }
        public int InventoryID { get; set; }
    }
}
