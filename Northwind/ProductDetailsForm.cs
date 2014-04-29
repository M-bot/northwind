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

            if(id < 1)
            {
                //New Product
                newProduct = true;
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
            if (newProduct) currentProduct = new Product();
        }

    }
}
