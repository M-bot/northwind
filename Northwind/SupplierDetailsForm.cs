﻿using System;
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
    public partial class SupplierDetailsForm : Form
    {
        private Supplier currentSupplier;

        public SupplierDetailsForm()
        {
            InitializeComponent();
        }

        private void SupplierDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private bool dataLoaded;

        private void loadData()
        {
            dataLoaded = true;
        }

        private bool newSupplier;

        public void loadSupplier(Int32 id)
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
            SupplierOrders.DataSource = null;

            if (id < 1)
            {
                newSupplier = true;

                headerTitle.Text = "Untitled";

            }
            else
            {
                currentSupplier = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM suppliers WHERE ID=" + id)
                    .QuerySingle<Supplier>();

                headerTitle.Text = currentSupplier.FirstName + " " + currentSupplier.LastName;
                companyBox.Text = currentSupplier.Company;
                firstNameBox.Text = currentSupplier.FirstName;
                lastNameBox.Text = currentSupplier.LastName;
                jobTitleBox.Text = currentSupplier.JobTitle;
                businessPhoneBox.Text = currentSupplier.BusinessPhone;
                mobilePhoneBox.Text = currentSupplier.MobilePhone;
                faxNumberBox.Text = currentSupplier.FaxNumber;
                streetBox.Text = currentSupplier.Address;
                cityBox.Text = currentSupplier.City;
                stateProvinceBox.Text = currentSupplier.State_Province;
                zipPostalCodeBox.Text = currentSupplier.ZIP_PostalCode;
                countryRegionBox.Text = currentSupplier.Country_Region;
                emailBox.Text = currentSupplier.EmailAddress;
                webPageBox.Text = currentSupplier.WebPage;
                notesBox.Text = currentSupplier.Notes;
                SupplierOrders.DataSource = null;

                newSupplier = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool failure = false;
            currentSupplier.Address = streetBox.Text;
            currentSupplier.BusinessPhone = businessPhoneBox.Text;
            currentSupplier.City = cityBox.Text;
            currentSupplier.Company = companyBox.Text;
            currentSupplier.Country_Region = countryRegionBox.Text;
            currentSupplier.EmailAddress = emailBox.Text;
            currentSupplier.FaxNumber = faxNumberBox.Text;
            currentSupplier.FirstName = firstNameBox.Text;
            currentSupplier.JobTitle = jobTitleBox.Text;
            currentSupplier.LastName = lastNameBox.Text;
            currentSupplier.MobilePhone = mobilePhoneBox.Text;
            currentSupplier.Notes = notesBox.Text;
            currentSupplier.State_Province = stateProvinceBox.Text;
            currentSupplier.WebPage = webPageBox.Text;
            currentSupplier.ZIP_PostalCode = zipPostalCodeBox.Text;


            if (failure)
            {
                MessageBox.Show("Errors in data, please revise.");
                return;
            }

            if (newSupplier)
            {
                int Supplier = Home.NorthwindDatabase.Context.Insert<Supplier>("suppliers", currentSupplier)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                loadSupplier(Supplier);
                MessageBox.Show("Created!");
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Supplier>("suppliers", currentSupplier)
                    .AutoMap(x => x.ID)
                    .Where(x => x.ID)
                    .Execute();

                loadSupplier(currentSupplier.ID);
                MessageBox.Show("Saved!");
            }
        }

        private void newLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadSupplier(0);
        }
    }
}