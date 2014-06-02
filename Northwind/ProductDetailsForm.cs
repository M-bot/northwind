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
        private bool errorsInData;

        private void loadData()
        {
            supplierBox.Items.AddRange(Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM suppliers ORDER BY Company ASC")
                .QueryMany<SupplierCompany>()
                .ToArray());

            categoryBox.Items.AddRange(Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM category ORDER BY Name ASC")
                .QueryMany<Category>()
                .ToArray());

            dataLoaded = true;
        }

        private bool newProduct;

        public void loadProduct(Int32 id)
        {
            if (!dataLoaded) loadData();

            foreach (CheckBoxComboBoxItem c in supplierBox.CheckBoxItems)
                c.Checked = false;

            statusLabel.Text = "";
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
            historyView.DataSource = null;
            defaultReorderBox.ForeColor = Color.Black;
            priceBox.ForeColor = Color.Black;
            reorderBox.ForeColor = Color.Black;
            costBox.ForeColor = Color.Black;
            targetBox.ForeColor = Color.Black;

            if(id < 1)
            {
                newProduct = true;
                headerTitle.Text = "Untitled";
                idBox.Text = "(New)";
                currentProduct = new Product();
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

                int xx = -1;
                foreach (Category c in categoryBox.Items)
                {
                    xx++;
                    if (c.ID == currentProduct.Category)
                    {
                        categoryBox.SelectedIndex = xx;
                        break;
                    }
                }

                historyView.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `product transactions` WHERE `Product ID` = " + currentProduct.ID)
                    .QuerySingle<DataTable>();

                historyView.Columns[0].Visible = false;

                newProduct = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentProduct.SupplierIDs = "";
            foreach (CheckBoxComboBoxItem c in supplierBox.CheckBoxItems)
                if (c.Checked)
                    currentProduct.SupplierIDs += ((Supplier)c.ComboBoxItem).ID + ";";
            currentProduct.SupplierIDs = currentProduct.SupplierIDs.Substring(0, currentProduct.SupplierIDs.Length - 1);

            currentProduct.Category = ((Category)categoryBox.SelectedItem).ID;
            currentProduct.Description = descriptionBox.Text;
            currentProduct.Discontinued = discontinuedBox.Checked;
            currentProduct.ProductCode = codeBox.Text;
            currentProduct.ProductName = nameBox.Text;
            currentProduct.QuantityPerUnit = quantityBox.Text;

            if(errorsInData)
            {
                statusLabel.Text = "Errors in data";
                return;
            }

            if(newProduct)
            {
                int product = Home.NorthwindDatabase.Context.Insert<Product>("products", currentProduct)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                loadProduct(product);
                statusLabel.Text = "Created";
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Product>("products", currentProduct)
                    .AutoMap(x => x.ID)
                    .Where(x => x.ID)
                    .Execute();

                loadProduct(currentProduct.ID);
                statusLabel.Text = "Saved";
            }
        }

        private void newLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadProduct(0);
        }

        private bool costBoxError = false;
        private void costBox_TextChanged(object sender, EventArgs e)
        {
            double temp = 0;
            if (!double.TryParse(costBox.Text.Contains("$") ? costBox.Text.Substring(1) : costBox.Text, out temp))
            {
                costBox.ForeColor = Color.Red;
            }
            else
            {
                costBox.ForeColor = Color.Black;
            }

            if(currentProduct != null)
                currentProduct.StandardCost = temp;
        }

        private bool priceBoxError = false;
        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            double temp = 0;
            if (!double.TryParse(priceBox.Text.Contains("$") ? priceBox.Text.Substring(1) : priceBox.Text, out temp))
            {
                priceBox.ForeColor = Color.Red;
            }
            else
            {
                priceBox.ForeColor = Color.Black;
            }

            if(currentProduct != null)
                currentProduct.ListPrice = temp;
        }

        private bool reorderBoxError = false;
        private void reorderBox_TextChanged(object sender, EventArgs e)
        {
            int temp = 0;
            if (!int.TryParse(reorderBox.Text, out temp))
            {
                reorderBox.ForeColor = Color.Red;
            }
            else
            {
                reorderBox.ForeColor = Color.Black;
            }
            
            if(currentProduct != null)
                currentProduct.ReorderLevel = temp;
        }

        private bool targetBoxError = false;
        private void targetBox_TextChanged(object sender, EventArgs e)
        {
            int temp = 0;
            if (!int.TryParse(targetBox.Text, out temp))
            {
                targetBox.ForeColor = Color.Red;
            }
            else
            {
                targetBox.ForeColor = Color.Black;
            }

            if(currentProduct != null)
                currentProduct.TargetLevel = temp;
        }

        private bool defaultReorderError = false;
        private void defaultReorderBox_TextChanged(object sender, EventArgs e)
        {
            int temp = 0;
            if (!int.TryParse(defaultReorderBox.Text, out temp))
            {
                defaultReorderBox.ForeColor = Color.Red;
            }
            else
            {
                defaultReorderBox.ForeColor = Color.Black;
            }

            if(currentProduct != null)
                currentProduct.MinimumReorderQuantity = temp;
        }

    }
}
