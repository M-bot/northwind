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
            supplierBox.Items.AddRange(Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM suppliers ORDER BY Company ASC")
                .QueryMany<SupplierCompany>()
                .ToArray());

            createdByBox.Items.AddRange(Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY FirstName ASC")
                .QueryMany<EmployeeName>()
                .ToArray());

            submittedByBox.Items.AddRange(Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY FirstName ASC")
                .QueryMany<EmployeeName>()
                .ToArray());

            approvedByBox.Items.AddRange(Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY FirstName ASC")
                .QueryMany<EmployeeName>()
                .ToArray());
            

            paymentTypeBox.Items.AddRange(new string[] { "Credit Card", "Check", "Cash" });
            dataLoaded = true;
        }

        public void loadOrder(Int32 id)
        {
            if (!dataLoaded) loadData();

            if (id < 1)
            {
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

                newOrder = true;
            }
            else
            {
                headerTitle.Text = "Purchase Order # (New)";
                currentOrder = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `purchase orders` WHERE `PurchaseOrderID`=" + id)
                    .QuerySingle<PurchaseOrder>();

                int x = -1;
                foreach (Supplier s in supplierBox.Items)
                {
                    x++;
                    if(s.ID == currentOrder.SupplierID)
                        break;
                }
                supplierBox.SelectedIndex = x;

                createdByBox.SelectedIndex = -1;
                submittedByBox.SelectedIndex = -1;
                approvedByBox.SelectedIndex = -1;

                expectedDateBox.Text = currentOrder.ExpectedDate.ToString();
                creationDateBox.Text = currentOrder.CreationDate.ToString();
                submittedDateBox.Text = currentOrder.SubmittedDate.ToString();
                approvedDateBox.Text = currentOrder.ApprovedDate.ToString();

                paymentDateBox.Text = "";
                paymentTypeBox.SelectedIndex = -1;
                orderNotesBox.Text = "";

                newOrder = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (newOrder) currentOrder = new PurchaseOrder();

            if (newOrder)
            {
                
            }
            else
            {
                
            }
        }
    }
}
