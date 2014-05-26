using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.Objects
{
    public class InvoiceReport : Report
    {
        public InvoiceReport(Order o)
        {
            if(o == null)
            {
                MessageBox.Show("Order does not exist!");
                return;
            }
            Subregion state1 = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `subregion` WHERE `ID`="+o.ShipState_Province)
                .QuerySingle<Subregion>();

            Region country1 = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `region` WHERE `ID`="+o.ShipCountry_Region)
                .QuerySingle<Objects.Region>();

            Customer cust = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `customers` WHERE `ID`="+o.CustomerID)
                .QuerySingle<Customer>();

            Subregion state2 = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `subregion` WHERE `ID`="+cust.State_Province)
                .QuerySingle<Subregion>();

            Region country2 = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `region` WHERE `ID`="+cust.Country_Region)
                .QuerySingle<Objects.Region>();

            Employee emp = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `employees` WHERE `ID`="+o.EmployeeID)
                .QuerySingle<Employee>();

            Shipper ship = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `shippers` WHERE `ID`="+o.ShipperID)
                .QuerySingle<Shipper>();

            DataTable table = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `order list_inner` WHERE `OrderID`=" + o.OrderID)
                .QuerySingle<DataTable>();

            DataRow totals = table.Rows[0];

            HTML = global::Northwind.Properties.Resources.InvoiceTemplate;
            replace("GeneratedDate", DateTime.Now.ToLongDateString());
            replace("ShipTo.FullName", o.ShipName);
            replace("ShipTo.Address", o.ShipAddress);
            replace("ShipTo.City",  o.ShipCity);
            if(state1 != null) replace("ShipTo.State",  state1.Name);
            replace("ShipTo.ZIP",  o.ShipZIP_PostalCode);
            if(country1 != null) replace("ShipTo.Country",  country1.Name);
            replace("Invoice#",  o.OrderID.ToString());
            replace("Order.Date",  o.OrderDate.ToShortDateString());
            replace("Order.Shipped",  o.ShippedDate.ToShortDateString());
            if (cust != null)
            {
                replace("Customer.Company", cust.Company);
                replace("Customer.Address", cust.Address);
                replace("Customer.ZIP", cust.ZIP_PostalCode);
                replace("Customer.City", cust.City);
                replace("Customer", cust.Company);
            }
            if(state2 != null) replace("Customer.State",  state2.Name);
            if(country2 != null) replace("Customer.Country", country2.Name);
            if(emp != null) replace("Salesperson",  emp.FirstName + " " + emp.LastName);
            if(ship != null) replace("Ship Via",  ship.Company);
            replace("Subtotal", ((double)totals["Sub Total"]).ToString("C"));
            replace("Freight", ((double)totals["ShippingFee"]).ToString("C"));
            replace("Total", ((double)totals["Order Total"]).ToString("C"));

            DataTable products = Home.NorthwindDatabase.Context
                .Sql("CALL `northwind`.`order details for #`(" + o.OrderID + ");")
                .QuerySingle<DataTable>();

            string result = "";
            foreach(DataRow drow in products.Rows)
            {
                result += "<tr>";
                result += "<td class=\"productID\">" + drow["ProductID"] + "</td>";
                result += "<td class=\"productName\">" + drow["Product"] + "</td>";
                result += "<td class=\"quantity\">" + drow["Qty"] + "</td>";
                result += "<td class=\"unitPrice\">" + drow["Unit Price"] + "</td>";
                result += "<td class=\"discount\">" + drow["Discount"] + "</td>";
                result += "<td class=\"price\">" + drow["Total Price"] + "</td>";
                result += "</tr>";
            }

            replace("View",result);
            HTML = Regex.Replace(HTML, "{{.+}}", "");
        }
    }
}
