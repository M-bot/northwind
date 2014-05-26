using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.Objects;

namespace Northwind
{
    public partial class CustomerDetailsForm : Form
    {
        private Customer currentCustomer;

        public CustomerDetailsForm()
        {
            InitializeComponent();
        }

        private void CustomerDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private bool dataLoaded;

        private void loadData()
        {
            stateProvinceBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `subregion` WHERE `RegionID` = 1 ORDER BY `Name` ASC;")
                .QueryMany<Subregion>();

            countryRegionBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `region` ORDER BY `Name` ASC")
                .QueryMany<Objects.Region>();

            dataLoaded = true;
        }

        private bool newCustomer;

        public void loadCustomer(Int32 id)
        {
            if (!dataLoaded) loadData();

            companyBox.Text = "";
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            jobTitleBox.Text = "";
            businessPhoneBox.Text = "";
            mobilePhoneBox.Text = "";
            faxNumberBox.Text = "";
            streetBox.Text = "";
            cityBox.Text = "";
            stateProvinceBox.Text = "";
            zipPostalCodeBox.Text = "";
            countryRegionBox.Text = "";
            emailBox.Text = "";
            webPageBox.Text = "";
            notesBox.Text = "";
            customerOrders.DataSource = null;

            if(id < 1)
            {
                newCustomer = true;

                headerTitle.Text = "Untitled";

            }
            else
            {
                currentCustomer = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM customers WHERE ID=" + id)
                    .QuerySingle<Customer>();

                headerTitle.Text = currentCustomer.FirstName + " " + currentCustomer.LastName;
                companyBox.Text = currentCustomer.Company;
                firstNameBox.Text = currentCustomer.FirstName;
                lastNameBox.Text = currentCustomer.LastName;
                jobTitleBox.Text = currentCustomer.JobTitle;
                businessPhoneBox.Text = currentCustomer.BusinessPhone;
                mobilePhoneBox.Text = currentCustomer.MobilePhone;
                faxNumberBox.Text = currentCustomer.FaxNumber;
                streetBox.Text = currentCustomer.Address;
                cityBox.Text = currentCustomer.City;
                zipPostalCodeBox.Text = currentCustomer.ZIP_PostalCode;
                emailBox.Text = currentCustomer.EmailAddress;
                webPageBox.Text = currentCustomer.WebPage;
                notesBox.Text = currentCustomer.Notes;
                customerOrders.DataSource = null;

                for (int x = 0; x < stateProvinceBox.Items.Count; x++)
                    if (((Subregion)stateProvinceBox.Items[x]).ID == currentCustomer.State_Province)
                        stateProvinceBox.SelectedIndex = x;

                for (int x = 0; x < countryRegionBox.Items.Count; x++)
                    if (((Objects.Region)countryRegionBox.Items[x]).ID == currentCustomer.Country_Region)
                        countryRegionBox.SelectedIndex = x;

                newCustomer = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool failure = false;
            if (newCustomer) currentCustomer = new Customer();
            currentCustomer.Address = streetBox.Text;
            currentCustomer.BusinessPhone = businessPhoneBox.Text;
            currentCustomer.City = cityBox.Text;
            currentCustomer.Company = companyBox.Text;
            if (countryRegionBox.SelectedItem != null)
                currentCustomer.Country_Region = ((Objects.Region)countryRegionBox.SelectedItem).ID;
            currentCustomer.EmailAddress = emailBox.Text;
            currentCustomer.FaxNumber = faxNumberBox.Text;
            currentCustomer.FirstName = firstNameBox.Text;
            currentCustomer.JobTitle = jobTitleBox.Text;
            currentCustomer.LastName = lastNameBox.Text;
            currentCustomer.MobilePhone = mobilePhoneBox.Text;
            currentCustomer.Notes = notesBox.Text;
            if (stateProvinceBox.SelectedItem != null)
                currentCustomer.State_Province = ((Northwind.Objects.Subregion)stateProvinceBox.SelectedItem).ID;
            currentCustomer.WebPage = webPageBox.Text;
            currentCustomer.ZIP_PostalCode = zipPostalCodeBox.Text;

            
            if(failure)
            {
                MessageBox.Show("Errors in data, please revise.");
                return;
            }

            if(newCustomer)
            {
                int Customer = Home.NorthwindDatabase.Context.Insert<Customer>("Customers", currentCustomer)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                loadCustomer(Customer);
                MessageBox.Show("Created!");
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Customer>("Customers", currentCustomer)
                    .AutoMap(x => x.ID)
                    .Where(x => x.ID)
                    .Execute();

                loadCustomer(currentCustomer.ID);
                MessageBox.Show("Saved!");
            }
        }

        private void newLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadCustomer(0);
        }
    }
}
