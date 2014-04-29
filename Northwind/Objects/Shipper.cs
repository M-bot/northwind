using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class Shipper
    {
        public int ID { get; set; }
        public string Company { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State_Province { get; set; }
        public string ZIP_PostalCode { get; set; }
        public string Country_Region { get; set; }
        public string WebPage { get; set; }
        public string Notes { get; set; }
        public string Attachments { get; set; }
    }

    public class ShipperCompany : Shipper
    {
        public override string ToString()
        {
            return this.Company;
        }
    }
}
