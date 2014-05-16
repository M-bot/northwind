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
    public partial class CustomerOrderForm : Form
    {

        private Order currentOrder;

        public CustomerOrderForm()
        {
            InitializeComponent();
        }

        private void CustomerOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            
        }

        private bool dataLoaded = false;
        private bool newOrder = false;
        Product[] products;

        public void loadData()
        {
            stateProvinceBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `subregion` WHERE `RegionID` = 1 ORDER BY `Name` ASC;")
                .QueryMany<Subregion>();

            countryRegionBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `region` ORDER BY `Name` ASC")
                .QueryMany<Objects.Region>();

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

            products = (Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM products ORDER BY ProductName ASC")
                .QueryMany<Product>())
                .ToArray();
            productColumn.Items.AddRange(products);

            paymentTypeBox.Items.AddRange(new string[] { "Credit Card", "Check", "Cash" });
            dataLoaded = true;
        }


        public void loadOrder(Int32 id)
        {
            if (!dataLoaded) loadData();
            if(id < 1)
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

                for (int x = 0; x < customerBox.Items.Count; x++)
                    if (((Customer)customerBox.Items[x]).ID == currentOrder.CustomerID)
                        customerBox.SelectedIndex = x;

                for (int x = 0; x < salespersonBox.Items.Count; x++)
                    if (((Employee)salespersonBox.Items[x]).ID == currentOrder.EmployeeID)
                        salespersonBox.SelectedIndex = x;

                for (int x = 0; x < shippingCompanyBox.Items.Count; x++)
                    if (((Customer)customerBox.Items[x]).ID == currentOrder.CustomerID)
                        customerBox.SelectedIndex = x;
                

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

                orderDetailsView.Rows.Clear();
                DataTable orderDetailsData = Home.NorthwindDatabase.Context
                    .Sql("CALL `northwind`.`order details for #`(" + id + ");")
                    .QuerySingle<DataTable>();
                foreach(DataRow drow in orderDetailsData.Rows)
                {
                    object[] array = new object[drow.ItemArray.Length-1];
                    Array.Copy(drow.ItemArray,2,array,1,drow.ItemArray.Length-2);
                    foreach(Product p in products)
                    {
                        if (p.ID == (Int32)drow.ItemArray[0])
                            array[0] = p;
                    }
                    orderDetailsView.Rows.Add(array);
                }

                newOrder = false;
            }
        }

        private void clearAddressButton_Click(object sender, EventArgs e)
        {
            shipAddressBox.Text = "";
            shipNameBox.Text = "";
            cityBox.Text = "";
            zipPostalBox.Text = "";
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
            currentOrder.ShipCountry_Region = ((Objects.Region)countryRegionBox.SelectedItem).ID;
            currentOrder.ShipName = shipNameBox.Text;
            temp = new DateTime();
            DateTime.TryParse(shipDateBox.Text, out temp);
            currentOrder.OrderDate = temp;
            Double temp2 = 0;
            Double.TryParse(shippingFeeBox.Text.Contains("$") ? shippingFeeBox.Text.Substring(1) : shippingFeeBox.Text, out temp2);
            currentOrder.ShippingFee = temp2;
            currentOrder.ShipState_Province = ((Northwind.Objects.Subregion)stateProvinceBox.SelectedItem).ID;
            currentOrder.ShipZIP_PostalCode = zipPostalBox.Text;
            if(shippingCompanyBox.SelectedItem != null)
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

        private void customerLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + orderDetailsView.Rows[0].Cells[0].Value);
        }
    }
}
