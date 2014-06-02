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
        string[] paymentTypes = new string[] { "Credit Card", "Check", "Cash" };

        public CustomerOrderForm()
        {
            InitializeComponent();
        }

        private void CustomerOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

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

            customerBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM customers ORDER BY Company ASC")
                .QueryMany<CustomerCompany>();

            salespersonBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY LastName ASC")
                .QueryMany<EmployeeName>();

            shippingCompanyBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM shippers ORDER BY Company ASC")
                .QueryMany<ShipperCompany>();

            products = (Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM products ORDER BY ProductName ASC")
                .QueryMany<Product>())
                .ToArray();
            productColumn.DataSource = products;
            productColumn.ValueMember = "ID";
            productColumn.DisplayMember = "ProductName";

            paymentTypeBox.DataSource = paymentTypes;
        }


        public void loadOrder(Int32 id)
        {
            loadData();

            headerTitle.Text = "Order # (New)";
            customerBox.SelectedIndex = -1;
            salespersonBox.SelectedIndex = -1;
            shippingCompanyBox.SelectedIndex = -1;
            stateProvinceBox.SelectedIndex = -1;
            countryRegionBox.SelectedIndex = -1;

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

            orderDetailsView.Rows.Clear();
            orderDetailsView.ReadOnly = true;
            orderDetailsView.AllowUserToAddRows = true;
            createInvoiceLink.Enabled = true;
            shipOrderLink.Enabled = true;
            deleteOrderLink.Enabled = true;
            completeOrderLink.Enabled = true;
            customerBox.Enabled = true;
            salespersonBox.Enabled = true;
            shippingInformationTab.Enabled = true;
            paymentInformation.Enabled = true;

            if(id < 1)
            {
                newOrder = true;
            }
            else
            {
                currentOrder = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM orders WHERE OrderID = " + id)
                    .QuerySingle<Order>();
                headerTitle.Text = "Order #" + id;

                Status stat = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `orders status` WHERE `ID` = " + currentOrder.StatusID)
                    .QuerySingle<Status>();
                statusText.Text = stat.Name;
                if (stat.ID == 0) orderDetailsView.ReadOnly = false;
                if(stat.ID > 0)
                {
                    createInvoiceLink.Enabled = false;
                    orderDetailsView.ReadOnly = true;
                    salespersonBox.Enabled = false;
                    customerBox.Enabled = false;
                    orderDetailsView.AllowUserToAddRows = false;
                    if(stat.ID > 1)
                    {
                        shipOrderLink.Enabled = false;
                        shippingInformationTab.Enabled = false;
                        deleteOrderLink.Enabled = false;
                        if(stat.ID > 2)
                        {
                            paymentInformation.Enabled = false;
                            completeOrderLink.Enabled = false;
                        }
                    }
                }


                for (int x = 0; x < customerBox.Items.Count; x++)
                    if (((Customer)customerBox.Items[x]).ID == currentOrder.CustomerID)
                        customerBox.SelectedIndex = x;

                for (int x = 0; x < salespersonBox.Items.Count; x++)
                    if (((Employee)salespersonBox.Items[x]).ID == currentOrder.EmployeeID)
                        salespersonBox.SelectedIndex = x;

                for (int x = 0; x < shippingCompanyBox.Items.Count; x++)
                    if (((Shipper)shippingCompanyBox.Items[x]).ID == currentOrder.ShipperID)
                        shippingCompanyBox.SelectedIndex = x;

                for (int x = 0; x < stateProvinceBox.Items.Count; x++)
                    if (((Subregion)stateProvinceBox.Items[x]).ID == currentOrder.ShipState_Province)
                        stateProvinceBox.SelectedIndex = x;

                for (int x = 0; x < countryRegionBox.Items.Count; x++)
                    if (((Objects.Region)countryRegionBox.Items[x]).ID == currentOrder.ShipCountry_Region)
                        countryRegionBox.SelectedIndex = x;
                
                if(customerBox.SelectedItem != null)
                    emailAddressBox.Text = ((Customer)customerBox.SelectedItem).EmailAddress;

                orderDateBox.Text = currentOrder.OrderDate.ToString();

                shipAddressBox.Text = currentOrder.ShipAddress;
                shipDateBox.Text = currentOrder.ShippedDate.Ticks == 0 ? "" : currentOrder.ShippedDate.ToString();
                shipNameBox.Text = currentOrder.ShipName;
                shippingFeeBox.Text = currentOrder.ShippingFee.ToString("C");
                cityBox.Text = currentOrder.ShipCity;

                zipPostalBox.Text = currentOrder.ShipZIP_PostalCode;


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
                            array[0] = p.ID;
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
            if (salespersonBox.SelectedItem != null)
                currentOrder.EmployeeID = ((Employee)salespersonBox.SelectedItem).ID;
            if (customerBox.SelectedItem != null)
                currentOrder.CustomerID = ((Customer)customerBox.SelectedItem).ID;
            currentOrder.Notes = orderNotesBox.Text;
            DateTime temp = DateTime.Now;
            DateTime.TryParse(orderDateBox.Text, out temp);
            currentOrder.OrderDate = temp.Ticks == 0 ? DateTime.Now : temp;
            temp = new DateTime();
            DateTime.TryParse(paymentDateBox.Text, out temp);
            currentOrder.PaidDate = temp;
            currentOrder.PaymentType = paymentTypeBox.Text;
            currentOrder.ShipAddress = shipAddressBox.Text;
            currentOrder.ShipCity = cityBox.Text;
            if (countryRegionBox.SelectedItem != null)
                currentOrder.ShipCountry_Region = ((Objects.Region)countryRegionBox.SelectedItem).ID;
            currentOrder.ShipName = shipNameBox.Text;
            temp = new DateTime();
            DateTime.TryParse(shipDateBox.Text, out temp);
            currentOrder.ShippedDate = temp;
            Double temp2 = 0;
            Double.TryParse(shippingFeeBox.Text.Contains("$") ? shippingFeeBox.Text.Substring(1) : shippingFeeBox.Text, out temp2);
            currentOrder.ShippingFee = temp2;
            if (stateProvinceBox.SelectedItem != null)
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
                loadOrder(order);
                MessageBox.Show("Created!");
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Order>("orders", currentOrder)
                    .AutoMap(x => x.OrderID)
                    .Where(x => x.OrderID)
                    .Execute();
                loadOrder(currentOrder.OrderID);
                MessageBox.Show("Saved!");
            }
        }

        private void customerLabel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("" + orderDetailsView.Rows[0].Cells[0].Value);
        }

        private void orderDetailsView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            //MessageBox.Show(orderDetailsView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " " + e.RowIndex + " " + e.ColumnIndex + " " + e.Context + " " + e.Exception);
        }

        private void orderDetailsView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            orderDetailsView.Rows[e.RowIndex].Cells[0].Value = orderDetailsView.Rows[e.RowIndex].Cells[0].Value == null ? 1 : orderDetailsView.Rows[e.RowIndex].Cells[0].Value;
            orderDetailsView.Rows[e.RowIndex].Cells[1].Value = orderDetailsView.Rows[e.RowIndex].Cells[1].Value == null ? 0 : orderDetailsView.Rows[e.RowIndex].Cells[1].Value;
            orderDetailsView.Rows[e.RowIndex].Cells[3].Value = orderDetailsView.Rows[e.RowIndex].Cells[3].Value == null ? 0 : orderDetailsView.Rows[e.RowIndex].Cells[3].Value;

            Product p = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM products WHERE `ID`=" + ((DataGridViewComboBoxCell)orderDetailsView.Rows[e.RowIndex].Cells[0]).Value)
                .QuerySingle<Product>();

            string disc = orderDetailsView.Rows[e.RowIndex].Cells[3].Value.ToString();
            double discount = 0;
            double.TryParse(disc.Contains("%") ? disc.Substring(0, disc.Length-2) : disc, out discount);
            int qty = Int32.Parse(orderDetailsView.Rows[e.RowIndex].Cells[1].Value.ToString());

            orderDetailsView.Rows[e.RowIndex].Cells[2].Value = p.ListPrice;

            orderDetailsView.Rows[e.RowIndex].Cells[4].Value = p.ListPrice * qty * (1-(discount/100));
            

            OrderDetails od = null;
            if (orderDetailsView.Rows[e.RowIndex].Cells[6].Value == null)
            {
                od = new OrderDetails();

                od.OrderID = currentOrder.OrderID;
                od.ProductID = p.ID;
                od.Quantity = qty;
                od.UnitPrice = p.ListPrice;
                od.Discount = discount/100;
                od.StatusID = od.StatusID < 2 ? qty > 0 ? 1 : 0 : od.StatusID;

                int detail = Home.NorthwindDatabase.Context.Insert<OrderDetails>("`order details`", od)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                orderDetailsView.Rows[e.RowIndex].Cells[6].Value = detail;
            }
            else
            {
                Int32 id = (Int32)orderDetailsView.Rows[e.RowIndex].Cells[6].Value;
                od = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `order details` WHERE `ID`=" + id)
                    .QuerySingle<OrderDetails>();

                od.OrderID = currentOrder.OrderID;
                od.ProductID = p.ID;
                od.Quantity = qty;
                od.UnitPrice = p.ListPrice;
                od.Discount = discount;
                od.StatusID = od.StatusID < 2 ? qty > 0 ? 1 : 0 : od.StatusID;

                Home.NorthwindDatabase.Context.Update<OrderDetails>("`order details`", od)
                   .AutoMap(x => x.ID)
                   .Where(x => x.ID)
                   .Execute();
            }

        }

        private void orderDetailsView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void createInvoiceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Order order = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM orders WHERE OrderID = " + currentOrder.OrderID)
                .QuerySingle<Order>();
            if(order.StatusID == 0)
                order.StatusID = 1;
            Home.NorthwindDatabase.Context.Update<Order>("orders", order)
                    .AutoMap(x => x.OrderID)
                    .Where(x => x.OrderID)
                    .Execute();
            loadOrder(currentOrder.OrderID);
        }

        private void shipOrderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Order order = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM orders WHERE OrderID = " + currentOrder.OrderID)
                .QuerySingle<Order>();
            if (order.StatusID == 1)
                order.StatusID = 2;
            Home.NorthwindDatabase.Context.Update<Order>("orders", order)
                    .AutoMap(x => x.OrderID)
                    .Where(x => x.OrderID)
                    .Execute();
            loadOrder(currentOrder.OrderID); 
        }

        private void completeOrderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Order order = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM orders WHERE OrderID = " + currentOrder.OrderID)
                .QuerySingle<Order>();
            if (order.StatusID == 2)
                order.StatusID = 3;
            Home.NorthwindDatabase.Context.Update<Order>("orders", order)
                    .AutoMap(x => x.OrderID)
                    .Where(x => x.OrderID)
                    .Execute();
            loadOrder(currentOrder.OrderID);
        }

        private void deleteOrderLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
