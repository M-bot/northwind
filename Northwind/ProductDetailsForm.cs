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
using PresentationControls;

namespace Northwind
{
    public partial class ProductDetailsForm : Form
    {

        private Product currentProduct;

        public ProductDetailsForm()
        {
            InitializeComponent();
        }

        private void ProductDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private bool dataLoaded;

        private void loadData()
        {
            supplierBox.Items.AddRange(Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM suppliers  ORDER BY Company ASC")
                .QueryMany<SupplierCompany>()
                .ToArray());

            dataLoaded = true;
        }

        private bool newProduct;

        public void loadProduct(Int32 id)
        {
            if (!dataLoaded) loadData();

            foreach (CheckBoxComboBoxItem c in supplierBox.CheckBoxItems)
                c.Checked = false;

            idBox.Text = "";
            codeBox.Text = "";
            nameBox.Text = "";
            descriptionBox.Text = "";
            costBox.Text = "$0.00";
            priceBox.Text = "$0.00";
            reorderBox.Text = "";
            targetBox.Text = "";
            quantityBox.Text = "";
            discontinuedBox.Checked = false;
            defaultReorderBox.Text = "";
            categoryBox.Text = "";
            historyView.DataSource = null;

            if(id < 1)
            {
                //New Product
                newProduct = true;

                headerTitle.Text = "Untitled";
                idBox.Text = "(New)";
                codeBox.Text = "";
                nameBox.Text = "";
                descriptionBox.Text = "";
                costBox.Text = "$0.00";
                priceBox.Text = "$0.00";
                reorderBox.Text = "";
                targetBox.Text = "";
                quantityBox.Text = "";
                discontinuedBox.Checked = false;
                defaultReorderBox.Text = "";
                categoryBox.Text = "";
            }
            else
            {
                currentProduct = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM products WHERE ID = " + id)
                    .QuerySingle<Product>();

                headerTitle.Text = currentProduct.ProductName;

                string[] strings = currentProduct.SupplierIDs.Split(new char[]{';'});
                foreach (string s in strings)
                {
                    int x = 0;
                    foreach(Supplier ss in supplierBox.Items)
                    {
                        if(ss.ID == Int32.Parse(s))
                            supplierBox.CheckBoxItems[x].Checked = true;
                        x++;
                    }
                }

                idBox.Text = currentProduct.ID.ToString();
                codeBox.Text = currentProduct.ProductCode;
                nameBox.Text = currentProduct.ProductName;
                descriptionBox.Text = currentProduct.Description;
                costBox.Text = currentProduct.StandardCost.ToString("C");
                priceBox.Text = currentProduct.ListPrice.ToString("C");
                reorderBox.Text = currentProduct.ReorderLevel.ToString();
                targetBox.Text = currentProduct.TargetLevel.ToString();
                quantityBox.Text = currentProduct.QuantityPerUnit;
                discontinuedBox.Checked = currentProduct.Discontinued;
                defaultReorderBox.Text = currentProduct.MinimumReorderQuantity.ToString();
                categoryBox.Text = currentProduct.Category;

                historyView.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `product transactions` WHERE `Product ID` = " + currentProduct.ID)
                    .QuerySingle<DataTable>();

                historyView.Columns[0].Visible = false;

                newProduct = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool failure = false;
            if (newProduct) currentProduct = new Product();
            currentProduct.SupplierIDs = "";
            foreach (CheckBoxComboBoxItem c in supplierBox.CheckBoxItems)
                if (c.Checked)
                    currentProduct.SupplierIDs += ((Supplier)c.ComboBoxItem).ID + ";";
            currentProduct.SupplierIDs = currentProduct.SupplierIDs.Substring(0, currentProduct.SupplierIDs.Length - 1);

            currentProduct.Category = categoryBox.Text;
            currentProduct.Description = descriptionBox.Text;
            currentProduct.Discontinued = discontinuedBox.Checked;

            Double temp2 = 0;
            if (!Double.TryParse(priceBox.Text.Contains("$") ? priceBox.Text.Substring(1) : priceBox.Text, out temp2))
                priceBox.ForeColor = Color.Red;
            else
                priceBox.ForeColor = Color.Black;
            currentProduct.ListPrice = temp2;

            Int32 temp = 0;
            if (!Int32.TryParse(defaultReorderBox.Text, out temp))
                defaultReorderBox.ForeColor = Color.Red;
            else
                defaultReorderBox.ForeColor = Color.Black;
            currentProduct.MinimumReorderQuantity = temp;

            currentProduct.ProductCode = codeBox.Text;
            currentProduct.ProductName = nameBox.Text;
            currentProduct.QuantityPerUnit = quantityBox.Text;

            temp = 0;
            if (!Int32.TryParse(reorderBox.Text, out temp))
                reorderBox.ForeColor = Color.Red;
            else
                reorderBox.ForeColor = Color.Black;
            currentProduct.ReorderLevel = temp;

            temp2 = 0;
            if (!Double.TryParse(costBox.Text.Contains("$") ? costBox.Text.Substring(1) : costBox.Text, out temp2))
                costBox.ForeColor = Color.Red;
            else
                costBox.ForeColor = Color.Black;
            currentProduct.StandardCost = temp2;

            temp = 0;
            if (!Int32.TryParse(targetBox.Text, out temp))
                targetBox.ForeColor = Color.Red;
            else
                targetBox.ForeColor = Color.Black;
            currentProduct.TargetLevel = temp;

            failure |= !Double.TryParse(priceBox.Text.Contains("$") ? priceBox.Text.Substring(1) : priceBox.Text, out temp2);
            failure |= !Int32.TryParse(defaultReorderBox.Text, out temp);
            failure |= !Int32.TryParse(reorderBox.Text, out temp);
            failure |= !Double.TryParse(costBox.Text.Contains("$") ? costBox.Text.Substring(1) : costBox.Text, out temp2);
            failure |= !Int32.TryParse(targetBox.Text, out temp);
            if(failure)
            {
                MessageBox.Show("Errors in data, please revise.");
                return;
            }

            if(newProduct)
            {
                int product = Home.NorthwindDatabase.Context.Insert<Product>("products", currentProduct)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                loadProduct(product);
                MessageBox.Show("Created!");
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Product>("products", currentProduct)
                    .AutoMap(x => x.ID)
                    .Where(x => x.ID)
                    .Execute();

                loadProduct(currentProduct.ID);
                MessageBox.Show("Saved!");
            }
        }

        private void newLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadProduct(0);
        }

    }
}
