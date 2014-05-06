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
    public partial class PurchaseOrderForm : Form
    {
        private PurchaseOrder currentOrder;

        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void PurchaseOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private bool dataLoaded = false;
        private bool newOrder = false;

        public void loadData()
        {

            customerBox.Items.AddRange((Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM customers ORDER BY Company ASC")
                .QueryMany<CustomerCompany>())
                .ToArray());

            salespersonBox.Items.AddRange((Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY LastName ASC")
                .QueryMany<EmployeeName>())
                .ToArray());

            shippingCompanyBox.Items.AddRange((Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM shippers ORDER BY Company ASC")
                .QueryMany<ShipperCompany>())
                .ToArray());

            paymentTypeBox.Items.AddRange(new string[] { "Credit Card", "Check", "Cash" });
            dataLoaded = true;
        }

        public void loadOrder(Int32 id)
        {
            if (!dataLoaded) loadData();
            if (id < 1)
            {
                headerTitle.Text = "Order # (New)";
                customerBox.SelectedIndex = -1;
                salespersonBox.SelectedIndex = -1;
                shippingCompanyBox.SelectedIndex = -1;

                emailAddressBox.Text = "";

                orderDateBox.Text = "";

                shipAddressBox.Text = "";
                shipDateBox.Text = "";
                shipNameBox.Text = "";
                shippingFeeBox.Text = "";
                cityBox.Text = "";
                stateProvinceBox.Text = "";
                zipPostalBox.Text = "";
                countryRegionBox.Text = "";

                paymentDateBox.Text = "";
                paymentTypeBox.Text = "";
                orderNotesBox.Text = "";

                newOrder = true;
            }
            else
            {
                currentOrder = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM orders WHERE OrderID = " + id)
                    .QuerySingle<Order>();
                headerTitle.Text = "Order #" + id;

                int x = -1;
                foreach (Customer c in customerBox.Items)
                {
                    x++;
                    if (c.ID == currentOrder.CustomerID)
                    {
                        customerBox.SelectedIndex = x;
                        break;
                    }
                }

                x = -1;
                foreach (Employee e in salespersonBox.Items)
                {
                    x++;
                    if (e.ID == currentOrder.EmployeeID)
                    {
                        salespersonBox.SelectedIndex = x;
                        break;
                    }
                }


                x = -1;
                foreach (Shipper s in shippingCompanyBox.Items)
                {
                    x++;
                    if (s.ID == currentOrder.ShipperID)
                    {
                        shippingCompanyBox.SelectedIndex = x;
                        break;
                    }
                }


                emailAddressBox.Text = ((Customer)customerBox.SelectedItem).EmailAddress;

                orderDateBox.Text = currentOrder.OrderDate.ToString();

                shipAddressBox.Text = currentOrder.ShipAddress;
                shipDateBox.Text = currentOrder.ShippedDate.Ticks == 0 ? "" : currentOrder.ShippedDate.ToString();
                shipNameBox.Text = currentOrder.ShipName;
                shippingFeeBox.Text = currentOrder.ShippingFee.ToString("C");
                cityBox.Text = currentOrder.ShipCity;
                stateProvinceBox.Text = currentOrder.ShipState_Province;
                zipPostalBox.Text = currentOrder.ShipZIP_PostalCode;
                countryRegionBox.Text = currentOrder.ShipCountry_Region;

                paymentDateBox.Text = currentOrder.PaidDate.Ticks == 0 ? "" : currentOrder.PaidDate.ToString();
                paymentTypeBox.Text = currentOrder.PaymentType;
                orderNotesBox.Text = currentOrder.Notes;

                DataTable temp = Home.NorthwindDatabase.Context
                    .Sql("CALL `northwind`.`order details for #`(" + id + ");")
                    .QuerySingle<DataTable>(); ;

                DataGridViewComboBoxColumn d = new DataGridViewComboBoxColumn();
                d.Items.AddRange(Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM products")
                    .QueryMany<Product>()
                    .ToArray());
                d.Name = "Product";
                d.DataSource = temp.Columns[0].Container;
                orderDetailsView.Columns.Add(d);
                orderDetailsView.DataSource = temp;


                newOrder = false;
            }
        }

        private void clearAddressButton_Click(object sender, EventArgs e)
        {
            shipAddressBox.Text = "";
            shipNameBox.Text = "";
            cityBox.Text = "";
            stateProvinceBox.Text = "";
            zipPostalBox.Text = "";
            countryRegionBox.Text = "";
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (newOrder) currentOrder = new Order();
            currentOrder.EmployeeID = ((Employee)salespersonBox.SelectedItem).ID;
            currentOrder.CustomerID = ((Customer)customerBox.SelectedItem).ID;
            currentOrder.Notes = orderNotesBox.Text;
            DateTime temp = new DateTime();
            DateTime.TryParse(orderDateBox.Text, out temp);
            currentOrder.OrderDate = temp;
            temp = new DateTime();
            DateTime.TryParse(paymentDateBox.Text, out temp);
            currentOrder.PaidDate = temp;
            currentOrder.PaymentType = paymentTypeBox.Text;
            currentOrder.ShipAddress = shipAddressBox.Text;
            currentOrder.ShipCity = cityBox.Text;
            currentOrder.ShipCountry_Region = countryRegionBox.Text;
            currentOrder.ShipName = shipNameBox.Text;
            temp = new DateTime();
            DateTime.TryParse(shipDateBox.Text, out temp);
            currentOrder.OrderDate = temp;
            Double temp2 = 0;
            Double.TryParse(shippingFeeBox.Text.Contains("$") ? shippingFeeBox.Text.Substring(1) : shippingFeeBox.Text, out temp2);
            currentOrder.ShippingFee = temp2;
            currentOrder.ShipState_Province = stateProvinceBox.Text;
            currentOrder.ShipZIP_PostalCode = zipPostalBox.Text;
            if (shippingCompanyBox.SelectedItem != null)
                currentOrder.ShipperID = ((Shipper)shippingCompanyBox.SelectedItem).ID;
            if (newOrder)
            {
                int order = Home.NorthwindDatabase.Context.Insert<Order>("orders", currentOrder)
                    .AutoMap(x => x.OrderID)
                    .ExecuteReturnLastId<int>();
                currentOrder.OrderID = order;
                headerTitle.Text = "Order #" + order;
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Order>("orders", currentOrder)
                    .AutoMap(x => x.OrderID)
                    .Where(x => x.OrderID)
                    .Execute();
            }
        }
    }
}
