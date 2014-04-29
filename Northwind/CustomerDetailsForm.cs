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
                stateProvinceBox.Text = currentCustomer.State_Province;
                zipPostalCodeBox.Text = currentCustomer.ZIP_PostalCode;
                countryRegionBox.Text = currentCustomer.Country_Region;
                emailBox.Text = currentCustomer.EmailAddress;
                webPageBox.Text = currentCustomer.WebPage;
                notesBox.Text = currentCustomer.Notes;
                customerOrders.DataSource = null;

                newCustomer = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool failure = false;
            currentCustomer.Address = streetBox.Text;
            currentCustomer.BusinessPhone = businessPhoneBox.Text;
            currentCustomer.City = cityBox.Text;
            currentCustomer.Company = companyBox.Text;
            currentCustomer.Country_Region = countryRegionBox.Text;
            currentCustomer.EmailAddress = emailBox.Text;
            currentCustomer.FaxNumber = faxNumberBox.Text;
            currentCustomer.FirstName = firstNameBox.Text;
            currentCustomer.JobTitle = jobTitleBox.Text;
            currentCustomer.LastName = lastNameBox.Text;
            currentCustomer.MobilePhone = mobilePhoneBox.Text;
            currentCustomer.Notes = notesBox.Text;
            currentCustomer.State_Province = stateProvinceBox.Text;
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
