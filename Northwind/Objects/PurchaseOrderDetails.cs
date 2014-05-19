using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class PurchaseOrderDetails
    {
        public int ID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double UnitCost { get; set; }
        public DateTime DateReceived { get; set; }
        public bool PostedToInventory { get; set; }
        public int InventoryID { get; set; }
    }
}
