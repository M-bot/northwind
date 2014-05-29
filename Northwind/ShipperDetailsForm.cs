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
    public partial class ShipperDetailsForm : Form
    {
        private Shipper currentShipper;

        public ShipperDetailsForm()
        {
            InitializeComponent();
        }

        private void ShipperDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private bool newShipper;

        public void loadShipper(Int32 id)
        {
            loadData();

            companyBox.Text = "";
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            jobTitleBox.Text = "";
            businessPhoneBox.Text = "";
            mobilePhoneBox.Text = "";
            faxNumberBox.Text = "";
            streetBox.Text = "";
            cityBox.Text = "";
            zipPostalCodeBox.Text = "";
            emailBox.Text = "";
            webPageBox.Text = "";
            notesBox.Text = "";
            ShipperOrders.DataSource = null;

            if (id < 1)
            {
                newShipper = true;

                headerTitle.Text = "Untitled";

            }
            else
            {
                currentShipper = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM shippers WHERE ID=" + id)
                    .QuerySingle<Shipper>();

                headerTitle.Text = currentShipper.Company;
                companyBox.Text = currentShipper.Company;
                firstNameBox.Text = currentShipper.FirstName;
                lastNameBox.Text = currentShipper.LastName;
                jobTitleBox.Text = currentShipper.JobTitle;
                businessPhoneBox.Text = currentShipper.BusinessPhone;
                mobilePhoneBox.Text = currentShipper.MobilePhone;
                faxNumberBox.Text = currentShipper.FaxNumber;
                streetBox.Text = currentShipper.Address;
                cityBox.Text = currentShipper.City;
                zipPostalCodeBox.Text = currentShipper.ZIP_PostalCode;
                emailBox.Text = currentShipper.EmailAddress;
                webPageBox.Text = currentShipper.WebPage;
                notesBox.Text = currentShipper.Notes;
                ShipperOrders.DataSource = null;

                for (int x = 0; x < stateProvinceBox.Items.Count; x++)
                    if (((Subregion)stateProvinceBox.Items[x]).ID == currentShipper.State_Province)
                        stateProvinceBox.SelectedIndex = x;

                for (int x = 0; x < countryRegionBox.Items.Count; x++)
                    if (((Objects.Region)countryRegionBox.Items[x]).ID == currentShipper.Country_Region)
                        countryRegionBox.SelectedIndex = x;

                newShipper = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool failure = false;
            currentShipper.Address = streetBox.Text;
            currentShipper.BusinessPhone = businessPhoneBox.Text;
            currentShipper.City = cityBox.Text;
            currentShipper.Company = companyBox.Text;
            if (countryRegionBox.SelectedItem != null)
                currentShipper.Country_Region = ((Objects.Region)countryRegionBox.SelectedItem).ID;
            currentShipper.EmailAddress = emailBox.Text;
            currentShipper.FaxNumber = faxNumberBox.Text;
            currentShipper.FirstName = firstNameBox.Text;
            currentShipper.JobTitle = jobTitleBox.Text;
            currentShipper.LastName = lastNameBox.Text;
            currentShipper.MobilePhone = mobilePhoneBox.Text;
            currentShipper.Notes = notesBox.Text;
            if (stateProvinceBox.SelectedItem != null)
                currentShipper.State_Province = ((Northwind.Objects.Subregion)stateProvinceBox.SelectedItem).ID;
            currentShipper.WebPage = webPageBox.Text;
            currentShipper.ZIP_PostalCode = zipPostalCodeBox.Text;


            if (failure)
            {
                MessageBox.Show("Errors in data, please revise.");
                return;
            }

            if (newShipper)
            {
                int Shipper = Home.NorthwindDatabase.Context.Insert<Shipper>("shippers", currentShipper)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                loadShipper(Shipper);
                MessageBox.Show("Created!");
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Shipper>("shippers", currentShipper)
                    .AutoMap(x => x.ID)
                    .Where(x => x.ID)
                    .Execute();

                loadShipper(currentShipper.ID);
                MessageBox.Show("Saved!");
            }
        }

        private void newLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadShipper(0);
        }
    }
}
