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
            if(salesTypeBox.SelectedIndex == 3 && salesPeriodBox.SelectedIndex == 0)
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
                        r.replace("Headers", "<th>Employee</th><th></th><th>Sales</th>");
                        DataTable rows = Home.NorthwindDatabase.Context
                            .Sql("CALL `northwind`.`monthly sales report`(" + yearBox.SelectedItem + ", '" + monthBox.SelectedItem + "');")
                            .QuerySingle<DataTable>();

                        string result = "";
                        double total = 0;
                        foreach(DataRow drow in rows.Rows)
                        {
                            result += "<tr>";
                            result += "<td>" + drow["Salesperson"] + "</td>";
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
}
