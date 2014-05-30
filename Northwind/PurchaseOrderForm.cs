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
        string[] paymentTypes = new string[] { "Credit Card", "Check", "Cash" };

        public PurchaseOrderForm()
        {
            InitializeComponent();
        }

        private void PurchaseOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private bool newOrder = false;
        Product[] products;

        public void loadData()
        {
            supplierBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM suppliers ORDER BY Company ASC")
                .QueryMany<SupplierCompany>();

            createdByBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY FirstName ASC")
                .QueryMany<EmployeeName>();

            submittedByBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY FirstName ASC")
                .QueryMany<EmployeeName>();

            approvedByBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY FirstName ASC")
                .QueryMany<EmployeeName>();

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

            headerTitle.Text = "Purchase Order # (New)";

            supplierBox.SelectedIndex = -1;
            createdByBox.SelectedIndex = -1;
            submittedByBox.SelectedIndex = -1;
            approvedByBox.SelectedIndex = -1;

            expectedDateBox.Text = "";
            creationDateBox.Text = "";
            submittedDateBox.Text = "";
            approvedDateBox.Text = "";

            paymentDateBox.Text = "";
            paymentTypeBox.SelectedIndex = -1;
            orderNotesBox.Text = "";

            submitForApprovalLink.Enabled = true;
            purchaseDetailsView.ReadOnly = true;
            approvePurchaseLink.Enabled = true;
            paymentInformation.Enabled = false;
            supplierBox.Enabled = true;

            purchaseDetailsView.Rows.Clear();
            purchaseDetailsView.AllowUserToAddRows = true;

            if (id < 1)
            {
                newOrder = true;
            }
            else
            {
                headerTitle.Text = "Purchase Order #" + id;
                currentOrder = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `purchase orders` WHERE `PurchaseOrderID`=" + id)
                    .QuerySingle<PurchaseOrder>();

                Status stat = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `purchase order status` WHERE `ID` = " + currentOrder.StatusID)
                    .QuerySingle<Status>();
                statusText.Text = stat.Name;

                purchaseDetailsView.ReadOnly = false;
                if (stat.ID > 0)
                {
                    submitForApprovalLink.Enabled = false;
                    purchaseDetailsView.ReadOnly = true;
                    purchaseDetailsView.AllowUserToAddRows = false;
                    supplierBox.Enabled = false;
                    if (stat.ID > 1)
                    {
                        approvePurchaseLink.Enabled = false;
                        paymentInformation.Enabled = true;
                    }
                }

                for (int x = 0; x < supplierBox.Items.Count; x++)
                    if (((Supplier)supplierBox.Items[x]).ID == currentOrder.SupplierID)
                        supplierBox.SelectedIndex = x;

                for (int x = 0; x < approvedByBox.Items.Count; x++)
                    if (((Employee)approvedByBox.Items[x]).ID == currentOrder.ApprovedBy)
                        approvedByBox.SelectedIndex = x;

                for (int x = 0; x < createdByBox.Items.Count; x++)
                    if (((Employee)createdByBox.Items[x]).ID == currentOrder.CreatedBy)
                        createdByBox.SelectedIndex = x;

                for (int x = 0; x < submittedByBox.Items.Count; x++)
                    if (((Employee)submittedByBox.Items[x]).ID == currentOrder.SubmittedBy)
                        submittedByBox.SelectedIndex = x;

                expectedDateBox.Text = currentOrder.ExpectedDate.ToString();
                creationDateBox.Text = currentOrder.CreationDate.ToString();
                submittedDateBox.Text = currentOrder.SubmittedDate.ToString();
                approvedDateBox.Text = currentOrder.ApprovedDate.ToString();

                paymentDateBox.Text = "";
                paymentTypeBox.SelectedIndex = -1;
                orderNotesBox.Text = "";

                purchaseDetailsView.Rows.Clear();
                DataTable purchaseDetailsData = Home.NorthwindDatabase.Context
                    .Sql("CALL `northwind`.`purchase details for #`(" + id + ");")
                    .QuerySingle<DataTable>();
                foreach (DataRow drow in purchaseDetailsData.Rows)
                {
                    object[] array = new object[drow.ItemArray.Length - 1];
                    Array.Copy(drow.ItemArray, 2, array, 1, drow.ItemArray.Length - 2);
                    foreach (Product p in products)
                    {
                        if (p.ID == (Int32)drow.ItemArray[0])
                            array[0] = p.ID;
                    }
                    purchaseDetailsView.Rows.Add(array);
                }

                inventoryReceivingView.Rows.Clear();
                DataTable inventoryReceivingData = Home.NorthwindDatabase.Context
                    .Sql("CALL `northwind`.`inventory receiving for #`(" + id + ");")
                    .QuerySingle<DataTable>();
                foreach (DataRow drow in inventoryReceivingData.Rows)
                {
                    object[] array = new object[drow.ItemArray.Length];
                    Array.Copy(drow.ItemArray, 0, array, 0, drow.ItemArray.Length);
                    foreach (Product p in products)
                    {
                        if (p.ID == (Int32)drow.ItemArray[1])
                            array[1] = p;
                    }
                    array[4] = (ulong)drow.ItemArray[4] == 1;
                    inventoryReceivingView.Rows.Add(array);
                }

                newOrder = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (newOrder)
                currentOrder = new PurchaseOrder();
            DateTime temp = new DateTime();
            if(currentOrder.StatusID == 0)
            {
                currentOrder.CreatedBy = Home.currentEmployee.ID;
                currentOrder.CreationDate = DateTime.Now;
            }
            currentOrder.Notes = orderNotesBox.Text;
            DateTime.TryParse(paymentDateBox.Text, out temp);
            currentOrder.PaymentDate = temp;
            DateTime.TryParse(expectedDateBox.Text, out temp);
            currentOrder.ExpectedDate = temp;
            currentOrder.PaymentMethod = paymentTypeBox.Text;

            
            currentOrder.SupplierID = ((Supplier)supplierBox.SelectedItem).ID;

            if (newOrder)
            {
                int order = Home.NorthwindDatabase.Context.Insert<PurchaseOrder>("`purchase orders`", currentOrder)
                    .AutoMap(x => x.PurchaseOrderID)
                    .ExecuteReturnLastId<int>();
                currentOrder.PurchaseOrderID = order;
                loadOrder(order);
                MessageBox.Show("Created!");
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<PurchaseOrder>("`purchase orders`", currentOrder)
                    .AutoMap(x => x.PurchaseOrderID)
                    .Where(x => x.PurchaseOrderID)
                    .Execute();
                loadOrder(currentOrder.PurchaseOrderID);
                MessageBox.Show("Saved!");
            }
        }

        private void purchaseDetailsView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            //MessageBox.Show(purchaseDetailsView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " " + e.RowIndex + " " + e.ColumnIndex + " " + e.Context + " " + e.Exception);
        }

        private void purchaseDetailsView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            purchaseDetailsView.Rows[e.RowIndex].Cells[0].Value = purchaseDetailsView.Rows[e.RowIndex].Cells[0].Value == null ? 1 : purchaseDetailsView.Rows[e.RowIndex].Cells[0].Value;
            purchaseDetailsView.Rows[e.RowIndex].Cells[1].Value = purchaseDetailsView.Rows[e.RowIndex].Cells[1].Value == null ? 0 : purchaseDetailsView.Rows[e.RowIndex].Cells[1].Value;

            Product p = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM products WHERE `ID`=" + ((DataGridViewComboBoxCell)purchaseDetailsView.Rows[e.RowIndex].Cells[0]).Value)
                .QuerySingle<Product>();

            int qty = Int32.Parse(purchaseDetailsView.Rows[e.RowIndex].Cells[1].Value.ToString());

            purchaseDetailsView.Rows[e.RowIndex].Cells[2].Value = p.ListPrice;

            purchaseDetailsView.Rows[e.RowIndex].Cells[3].Value = p.ListPrice * qty;


            PurchaseOrderDetails od = null;
            if (purchaseDetailsView.Rows[e.RowIndex].Cells[4].Value == null)
            {
                od = new PurchaseOrderDetails();

                od.PurchaseOrderID = currentOrder.PurchaseOrderID;
                od.ProductID = p.ID;
                od.Quantity = qty;
                od.UnitCost = p.ListPrice;

                int detail = Home.NorthwindDatabase.Context.Insert<PurchaseOrderDetails>("`purchase order details`", od)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                purchaseDetailsView.Rows[e.RowIndex].Cells[4].Value = detail;
            }
            else
            {
                Int32 id = (Int32)purchaseDetailsView.Rows[e.RowIndex].Cells[4].Value;
                od = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `purchase order details` WHERE `ID`=" + id)
                    .QuerySingle<PurchaseOrderDetails>();

                od.PurchaseOrderID = currentOrder.PurchaseOrderID;
                od.ProductID = p.ID;
                od.Quantity = qty;
                od.UnitCost = p.ListPrice;

                Home.NorthwindDatabase.Context.Update<PurchaseOrderDetails>("`purchase order details`", od)
                   .AutoMap(x => x.ID)
                   .Where(x => x.ID)
                   .Execute();
            }

        }

        private void inventoryReceivingView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataTable inventoryReceivingData = Home.NorthwindDatabase.Context
                    .Sql("CALL `northwind`.`inventory receiving for #`(" + currentOrder.PurchaseOrderID + ");")
                    .QuerySingle<DataTable>();
            for (int x = 0; x < inventoryReceivingData.Rows.Count; x++)
            {
                if((ulong)inventoryReceivingData.Rows[x].ItemArray[4] == 0 && (bool)inventoryReceivingView[4,x].Value)
                {

                }
            }
        }

        private void submitForApprovalLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseOrder order = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `purchase orders` WHERE PurchaseOrderID = " + currentOrder.PurchaseOrderID)
                .QuerySingle<PurchaseOrder>();
            if (order.StatusID == 0)
            {
                order.StatusID = 1;
                order.SubmittedBy = Home.currentEmployee.ID;
                order.SubmittedDate = DateTime.Now;
            }
            Home.NorthwindDatabase.Context.Update<PurchaseOrder>("`purchase orders`", order)
                    .AutoMap(x => x.PurchaseOrderID)
                    .Where(x => x.PurchaseOrderID)
                    .Execute();
            loadOrder(currentOrder.PurchaseOrderID);
        }

        private void approvePurchaseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseOrder order = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `purchase orders` WHERE PurchaseOrderID = " + currentOrder.PurchaseOrderID)
                .QuerySingle<PurchaseOrder>();
            if (order.StatusID == 1)
            {
                order.StatusID = 2;
                order.ApprovedBy = Home.currentEmployee.ID;
                order.ApprovedDate = DateTime.Now;
            }
            Home.NorthwindDatabase.Context.Update<PurchaseOrder>("`purchase orders`", order)
                    .AutoMap(x => x.PurchaseOrderID)
                    .Where(x => x.PurchaseOrderID)
                    .Execute();
            loadOrder(currentOrder.PurchaseOrderID);
        }

        private void cancelPurchaseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}
