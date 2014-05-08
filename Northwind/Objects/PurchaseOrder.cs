using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class PurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public int SupplierID { get; set; }
        public int CreatedBy { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int StatusID { get; set; }
        public DateTime ExpectedDate { get; set; }
        public double ShippingFee { get; set; }
        public double Taxes { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string Notes { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public int SubmittedBy { get; set; }
    }
}
