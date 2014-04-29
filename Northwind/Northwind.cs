using Northwind.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Home : Form
    {
        public static Database NorthwindDatabase;
        public static Employee currentEmployee;
        private static CustomerOrderForm newCustomerOrderForm;
        private static PurchaseOrderForm newPurchaseOrderForm;
        private static ProductDetailsForm newProductDetailsForm;
        private static CustomerDetailsForm newCustomerDetailsForm;
        private static SupplierDetailsForm newSupplierDetailsForm;

        public Home()
        {
            LoginDialog dialog = new LoginDialog();
            newCustomerOrderForm = new CustomerOrderForm();
            newCustomerOrderForm.Hide();
            newPurchaseOrderForm = new PurchaseOrderForm();
            newPurchaseOrderForm.Hide();
            newProductDetailsForm = new ProductDetailsForm();
            newProductDetailsForm.Hide();
            newCustomerDetailsForm = new CustomerDetailsForm();
            newCustomerDetailsForm.Hide();
            newSupplierDetailsForm = new SupplierDetailsForm();
            newSupplierDetailsForm.Hide();
            dialog.ShowDialog(this);

            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            mainTabControl.TabPages.Clear();
            mainTabControl.TabPages.Add(homeTab);
        }

        private void inventoryLink_Click(object sender, EventArgs e)
        {
            inventoryView.DataSource = NorthwindDatabase.Context
                .Sql("SELECT * FROM `inventory list`")
                .QuerySingle<DataTable>();

            if(!mainTabControl.TabPages.Contains(inventoryTab))
                mainTabControl.TabPages.Add(inventoryTab);
            mainTabControl.SelectedTab = inventoryTab;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            activeOrdersView.DataSource = NorthwindDatabase.Context
                .Sql("CALL `northwind`.`Active Orders`(" + currentEmployee.ID + ");")
                .QuerySingle<DataTable>();

            employeeBox.Items.AddRange((Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY LastName ASC")
                .QueryMany<EmployeeLoginDialog>())
                .ToArray());

            //SELECT Inventory.* FROM Inventory WHERE (((Inventory.[Current Level])<[Reorder Level]));

            inventoryToReorderView.DataSource = NorthwindDatabase.Context
                .Sql("SELECT * FROM `inventory to reorder`;")
                .QuerySingle<DataTable>(); ;

            inventoryToReorderView.Columns[0].Visible = false;

            employeeBox.SelectedIndex = employeeBox.FindString(currentEmployee.ToString());
        }

        private void ordersLink_Click(object sender, EventArgs e)
        {
            ordersView.DataSource = NorthwindDatabase.Context
                .Sql("SELECT * FROM `order list`")
                .QuerySingle<DataTable>();

            if (!mainTabControl.TabPages.Contains(orderTab))
                mainTabControl.TabPages.Add(orderTab);
            mainTabControl.SelectedTab = orderTab;
        }

        private void customersLink_Click(object sender, EventArgs e)
        {
            customerView.DataSource = NorthwindDatabase.Context
                .Sql("SELECT * FROM `customer list`")
                .QuerySingle<DataTable>();

            if (!mainTabControl.TabPages.Contains(customerTab))
                mainTabControl.TabPages.Add(customerTab);
            mainTabControl.SelectedTab = customerTab;
        }

        private void purchaseOrdersLink_Click(object sender, EventArgs e)
        {
            if (!mainTabControl.TabPages.Contains(purchaseOrderTab))
                mainTabControl.TabPages.Add(purchaseOrderTab);
            mainTabControl.SelectedTab = purchaseOrderTab;
        }

        private void suppliersLink_Click(object sender, EventArgs e)
        {
            supplierView.DataSource = NorthwindDatabase.Context
                .Sql("SELECT * FROM `supplier list`")
                .QuerySingle<DataTable>();

            if (!mainTabControl.TabPages.Contains(supplierTab))
                mainTabControl.TabPages.Add(supplierTab);
            mainTabControl.SelectedTab = supplierTab;
        }

        private void employeesLink_Click(object sender, EventArgs e)
        {
            if (!mainTabControl.TabPages.Contains(employeeTab))
                mainTabControl.TabPages.Add(employeeTab);
            mainTabControl.SelectedTab = employeeTab;
        }

        private void shippersLink_Click(object sender, EventArgs e)
        {
            if (!mainTabControl.TabPages.Contains(shipperTab))
                mainTabControl.TabPages.Add(shipperTab);
            mainTabControl.SelectedTab = shipperTab;
        }

        private void salesReportLink_Click(object sender, EventArgs e)
        {

        }

        private void employeeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentEmployee = (Employee) employeeBox.SelectedItem;
            activeOrdersView.DataSource = NorthwindDatabase.Context
                .Sql("CALL `northwind`.`Active Orders`(" + currentEmployee.ID + ");")
                .QuerySingle<DataTable>();
        }

        private bool buttonColumnAdded = false;

        private void inventoryView_VisibleChanged(object sender, EventArgs e)
        {
            if (!buttonColumnAdded)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "";
                btnColumn.Name = "Purchase";
                btnColumn.Text = "Purchase";
                btnColumn.UseColumnTextForButtonValue = true;
                inventoryView.Columns.Insert(inventoryView.Columns.Count, btnColumn);
                buttonColumnAdded = true;
                inventoryView.Columns[0].Visible = false;
            }
        }

        private void inventoryView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != inventoryView.Columns["Purchase"].Index) return;

            if (Int32.Parse(inventoryView.Rows[e.RowIndex].Cells["Qty To Reorder"].Value.ToString()) <= 0)
                MessageBox.Show("Product does not need restocking! Product is already at desired inventory level.");
        }

        private void inventoryToReorderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Product Details Form");
        }

        private void newCustomerOrderLabel_Click(object sender, EventArgs e)
        {
            newCustomerOrderForm.loadOrder(0);
            newCustomerOrderForm.Show();
            newCustomerOrderForm.Activate();
        }

        private void newPurchaseOrderLabel_Click(object sender, EventArgs e)
        {
            newPurchaseOrderForm.Show();
            newPurchaseOrderForm.Activate();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = homeTab;
        }

        private void activeOrdersView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = 0;
            if (Int32.TryParse(activeOrdersView.Rows[e.RowIndex].Cells["#"].Value.ToString(), out id))
                newCustomerOrderForm.loadOrder(id);
            newCustomerOrderForm.Show();
            newCustomerOrderForm.Activate();
        }

        private void inventoryToReorderView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = 0;
            if (Int32.TryParse(inventoryToReorderView.Rows[e.RowIndex].Cells["#"].Value.ToString(), out id))
                newProductDetailsForm.loadProduct(id);
            newProductDetailsForm.Show();
            newProductDetailsForm.Activate();
        }

        private void addProductLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newProductDetailsForm.loadProduct(0);
            newProductDetailsForm.Show();
            newProductDetailsForm.Activate();
        }

        private void inventoryView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 8) return;
            int id = 0;
            if (Int32.TryParse(inventoryView.Rows[e.RowIndex].Cells["#"].Value.ToString(), out id))
                newProductDetailsForm.loadProduct(id);
            newProductDetailsForm.Show();
            newProductDetailsForm.Activate();
        }

        private void newCustomerLink_Click(object sender, EventArgs e)
        {
            newCustomerDetailsForm.loadCustomer(0);
            newCustomerDetailsForm.Show();
            newCustomerDetailsForm.Activate();
        }

        private void customerView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = 0;
            if (Int32.TryParse(customerView.Rows[e.RowIndex].Cells["ID"].Value.ToString(), out id))
                newCustomerDetailsForm.loadCustomer(id);
            newCustomerDetailsForm.Show();
            newCustomerDetailsForm.Activate();
        }

        private void newSupplierLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newSupplierDetailsForm.loadSupplier(0);
            newSupplierDetailsForm.Show();
            newSupplierDetailsForm.Activate();
        }

        private void supplierView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = 0;
            if (Int32.TryParse(supplierView.Rows[e.RowIndex].Cells["ID"].Value.ToString(), out id))
                newSupplierDetailsForm.loadSupplier(id);
            newSupplierDetailsForm.Show();
            newSupplierDetailsForm.Activate();
        }


    }
}
