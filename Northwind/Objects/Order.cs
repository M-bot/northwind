using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class Order
    {
        public int OrderID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipperID { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipState_Province { get; set; }
        public string ShipZIP_PostalCode { get; set; }
        public string ShipCountry_Region { get; set; }
        public double ShippingFee { get; set; }
        public double Taxes { get; set; }
        public string PaymentType { get; set; }
        public DateTime PaidDate { get; set; }
        public string Notes { get; set; }
        public double TaxRate { get; set; }
        public int TaxStatus { get; set; }
        public int StatusID { get; set; }
    }
}
