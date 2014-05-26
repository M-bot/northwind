using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Objects
{
    public class InvoiceReport : Report
    {
        public InvoiceReport(Order o)
        {
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
            HTML = HTML.Replace("{{GeneratedDate}}", DateTime.Now.ToLongDateString());
            HTML = HTML.Replace("{{ShipTo.FullName}}", o.ShipName);
            HTML = HTML.Replace("{{ShipTo.Address}}", o.ShipAddress);
            HTML = HTML.Replace("{{ShipTo.City}}",  o.ShipCity);
            HTML = HTML.Replace("{{ShipTo.State}}",  state1.Name);
            HTML = HTML.Replace("{{ShipTo.ZIP}}",  o.ShipZIP_PostalCode);
            HTML = HTML.Replace("{{ShipTo.Country}}",  country1.Name);
            HTML = HTML.Replace("{{Invoice#}}",  o.OrderID.ToString());
            HTML = HTML.Replace("{{Order.Date}}",  o.OrderDate.ToShortDateString());
            HTML = HTML.Replace("{{Order.Shipped}}",  o.ShippedDate.ToShortDateString());
            HTML = HTML.Replace("{{Customer.Company}}",  cust.Company);
            HTML = HTML.Replace("{{Customer.Address}}",  cust.Address);
            HTML = HTML.Replace("{{Customer.City}}",  cust.City);
            HTML = HTML.Replace("{{Customer.State}}",  state2.Name);
            HTML = HTML.Replace("{{Customer.ZIP}}",  cust.ZIP_PostalCode);
            HTML = HTML.Replace("{{Customer.Country}}", country2.Name);
            HTML = HTML.Replace("{{Salesperson}}",  emp.FirstName + " " + emp.LastName);
            HTML = HTML.Replace("{{Customer}}",  cust.Company);
            HTML = HTML.Replace("{{Ship Via}}",  ship.Company);
            HTML = HTML.Replace("{{Subtotal}}", ((double)totals["Sub Total"]).ToString("C"));
            HTML = HTML.Replace("{{Freight}}", ((double)totals["ShippingFee"]).ToString("C"));
            HTML = HTML.Replace("{{Total}}", ((double)totals["Order Total"]).ToString("C"));

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

            HTML = HTML.Replace("{{View}}",result);
        }
    }
}
