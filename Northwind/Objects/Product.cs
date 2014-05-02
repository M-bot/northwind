using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class Product
    {
        public string SupplierIDs { get; set; }
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int ReorderLevel { get; set; }
        public int TargetLevel { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }
        public int MinimumReorderQuantity { get; set; }
        public string Category { get; set; }
        public string Attachments { get; set; }

        public override string ToString()
        {
            return this.ProductName;
        }
    }
}
