using Northwind.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class SalesReportFrom : Form
    {
        public SalesReportFrom()
        {
            InitializeComponent();
        }

        private void SalesReportFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void SalesReportFrom_Load(object sender, EventArgs e)
        {
            yearBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT DISTINCT year(`OrderDate`) FROM `orders` ORDER BY year(`OrderDate`);")
                .QueryMany<int>();

            salesTypeBox.SelectedIndex = 0;
            salesPeriodBox.SelectedIndex = 0;
            quarterlyBox.SelectedIndex = 0;

            monthBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT DISTINCT monthname(`OrderDate`) FROM `orders` WHERE year(`OrderDate`) = " + yearBox.SelectedItem + " ORDER BY month(`OrderDate`);")
                .QueryMany<string>();

            filterSalesBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `category` ORDER BY `Name`;")
                .QueryMany<Category>();
        }

        private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT DISTINCT monthname(`OrderDate`) FROM `orders` WHERE year(`OrderDate`) = " + yearBox.SelectedItem + " ORDER BY month(`OrderDate`);")
                .QueryMany<string>();
        }

        private void salesPeriodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(salesPeriodBox.SelectedIndex == 0)
            {
                yearBox.Enabled = true;
                quarterlyBox.Enabled = false;
                monthBox.Enabled = true;
            }
            if (salesPeriodBox.SelectedIndex == 1)
            {
                yearBox.Enabled = true;
                quarterlyBox.Enabled = true;
                monthBox.Enabled = false;
            }
            if (salesPeriodBox.SelectedIndex == 2)
            {
                yearBox.Enabled = true;
                quarterlyBox.Enabled = false;
                monthBox.Enabled = false;
            }
        }

        private void salesTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (salesTypeBox.SelectedIndex == 0)
            {
                filterSalesBox.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `category` ORDER BY `Name`;")
                    .QueryMany<Category>();
            }
            if (salesTypeBox.SelectedIndex == 1)
            {
                filterSalesBox.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `region` ORDER BY `Name`;")
                    .QueryMany<Objects.Region>();
            }
            if (salesTypeBox.SelectedIndex == 2)
            {
                filterSalesBox.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `customers` ORDER BY `Company`;")
                    .QueryMany<CustomerCompany>();
            }
            if (salesTypeBox.SelectedIndex == 3)
            {
                filterSalesBox.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `employees` ORDER BY `LastName`;")
                    .QueryMany<EmployeeName>();
            }
            if (salesTypeBox.SelectedIndex == 4)
            {
                filterSalesBox.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `products` ORDER BY `ProductName`;")
                    .QueryMany<Product>();
            }
        }

        private void previewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Report r = new Report();
            r.HTML = global::Northwind.Properties.Resources.SalesReportTemplate;
            r.replace("GeneratedDate", DateTime.Now.ToLongDateString());
            r.replace("GeneratedTime", DateTime.Now.ToLongTimeString());
            r.replace("SalesPeriod", salesPeriodBox.SelectedItem);

            switch(salesPeriodBox.SelectedIndex)
            {
                case 0:
                    r.replace("SalesTime", monthBox.SelectedItem + ", " + yearBox.SelectedItem);
                    string result = "";
                    double total = 0;
                    DataTable rows = null;
                    switch(salesTypeBox.SelectedIndex)
                    {
                        case 0:
                            r.replace("Headers", "<th>Country</th><th></th><th>Sales</th>");
                            rows = Home.NorthwindDatabase.Context
                                .Sql("SELECT category.`Name`, sum(`UnitPrice` * `Quantity`) as `Total` FROM `orders` JOIN `order list` ON `OrderID` = `#`"+
                                "JOIN `order details` ON `orders`.`OrderID` = `order details`.`OrderID` JOIN products ON `order details`.`ProductID` = products.`ID`"+
                                "JOIN category ON products.Category = category.ID WHERE monthname(`Order Date`) = '" + monthBox.SelectedItem + "' AND year(`Order Date`) =  '" + yearBox.SelectedItem + "' AND `Status` = 'Closed' GROUP BY category.`ID`;")
                                .QuerySingle<DataTable>();
                            break;
                        case 1:
                            r.replace("Headers", "<th>Country</th><th></th><th>Sales</th>");
                            rows = Home.NorthwindDatabase.Context
                                .Sql("SELECT `Name`, sum(`Total`) as `Total` FROM `orders` JOIN `order list` ON `OrderID` = `#` JOIN region ON `ID` = `ShipCountry_Region` WHERE monthname(`Order Date`) = '" + monthBox.SelectedItem + "'  AND year(`Order Date`) = '" + yearBox.SelectedItem + "' AND `Status` = 'Closed' GROUP BY `ID`;")
                                .QuerySingle<DataTable>();
                            break;
                        case 2:
                            r.replace("Headers", "<th>Customer</th><th></th><th>Sales</th>");
                            rows = Home.NorthwindDatabase.Context
                                .Sql("SELECT `Customer` as `Name`,sum(`Total`) as `Total` FROM `order list`  WHERE monthname(`Order Date`) = '" + monthBox.SelectedItem + "'  AND year(`Order Date`) = '" + yearBox.SelectedItem + "' AND `Status` = 'Closed' GROUP BY `Customer`;")
                                .QuerySingle<DataTable>();
                            break;
                        case 3:
                            r.replace("Headers", "<th>Employee</th><th></th><th>Sales</th>");
                            rows = Home.NorthwindDatabase.Context
                                .Sql("SELECT `Salesperson` as `Name` ,sum(`Total`) as `Total` FROM `order list` WHERE monthname(`Order Date`) = '" + monthBox.SelectedItem + "'  AND year(`Order Date`) = '" + yearBox.SelectedItem + "' AND `Status` = 'Closed' GROUP BY `Salesperson`;")
                                .QuerySingle<DataTable>();
                            break;
                        case 4:
                            r.replace("Headers", "<th>Product</th><th></th><th>Sales</th>");
                            rows = Home.NorthwindDatabase.Context
                                .Sql("SELECT `ProductName` as `Name`, sum(`UnitPrice` * `Quantity`) as `Total` FROM `orders` JOIN `order list` ON `OrderID` = `#` " +
                                "JOIN `order details` ON `orders`.`OrderID` = `order details`.`OrderID` JOIN products ON `order details`.`ProductID` = products.`ID` " +
                                "WHERE monthname(`Order Date`) = '" + monthBox.SelectedItem + "' AND year(`Order Date`) =  '" + yearBox.SelectedItem + "' AND `Status` = 'Closed' GROUP BY products.`ID`;")
                                .QuerySingle<DataTable>();
                            break;
                    }

                    foreach (DataRow drow in rows.Rows)
                    {
                        result += "<tr>";
                        result += "<td>" + drow["Name"] + "</td>";
                        result += "<td>" + "" + "</td>";
                        result += "<td>" + ((double)drow["Total"]).ToString("C") + "</td>";
                        result += "</tr>";
                        total += ((double)drow["Total"]);
                    }

                    result += "<tr>";
                    result += "<td>" + "" + "</td>";
                    result += "<td>" + monthBox.SelectedItem + " Sales Total" + "</td>";
                    result += "<td>" + total.ToString("C") + "</td>";
                    result += "</tr>";

                    r.replace("Rows",result);
                    break;
                case 1:
                    r.replace("SalesTime", quarterlyBox.SelectedItem + ", " + yearBox.SelectedItem);
                    r.replace("Headers", "<th>Employee</th><th></th><th>Sales</th>");
                            
                    break;
                case 2:
                    r.replace("SalesTime", yearBox.SelectedItem);
                    break;
            }


            Home.newReportViewer.loadReport(r);
            Home.newReportViewer.Show();
            Home.newReportViewer.Activate();
        }
    }
}
