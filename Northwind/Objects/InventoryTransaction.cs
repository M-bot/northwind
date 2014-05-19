using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class InventoryTransaction
    {
        public int TransactionID {get; set;}
        public int TransactionType { get; set; }
        public DateTime TransactionCreatedDate { get; set; }
        public DateTime TransactionModifiedDate { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int PurchaseOrderID { get; set; }
        public int CustomerOrderID { get; set; }
        public int Comments { get; set; }
    }
}
