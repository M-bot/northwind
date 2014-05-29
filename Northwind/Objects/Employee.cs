using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int JobTitle { get; set; }
        public string BusinessPhone { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int State_Province { get; set; }
        public string ZIP_PostalCode { get; set; }
        public int Country_Region { get; set; }
        public string WebPage { get; set; }
        public string Notes { get; set; }
        public string Attachments { get; set; }
    }

    public class EmployeeLoginDialog : Employee
    {
        public override string ToString()
        {
            return FirstName + " " + LastName + " - " + Home.NorthwindDatabase.Context.Sql("SELECT `Name` FROM `jobtitle` WHERE `ID`="+JobTitle).QuerySingle<string>();
        }
    }

    public class EmployeeName : Employee
    {
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
