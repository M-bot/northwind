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
    public partial class EmployeeDetailsForm : Form
    {
        private Employee currentEmployee;

        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void EmployeeDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        private void loadData()
        {
            stateProvinceBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `subregion` WHERE `RegionID` = 1 ORDER BY `Name` ASC;")
                .QueryMany<Subregion>();

            countryRegionBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `region` ORDER BY `Name` ASC")
                .QueryMany<Objects.Region>();

            jobTitleBox.DataSource = Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM `jobtitle` ORDER BY `Name` ASC")
                .QueryMany<Objects.JobTitle>();

        }

        private bool newEmployee;

        public void loadEmployee(Int32 id)
        {
            loadData();

            firstNameBox.Text = "";
            lastNameBox.Text = "";
            businessPhoneBox.Text = "";
            mobilePhoneBox.Text = "";
            homePhoneBox.Text = "";
            faxNumberBox.Text = "";
            streetBox.Text = "";
            cityBox.Text = "";
            zipPostalCodeBox.Text = "";
            emailBox.Text = "";
            webPageBox.Text = "";
            notesBox.Text = "";
            employeeOrders.DataSource = null;

            if (id < 1)
            {
                newEmployee = true;

                headerTitle.Text = "Untitled";

            }
            else
            {
                currentEmployee = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM employees WHERE ID=" + id)
                    .QuerySingle<Employee>();

                headerTitle.Text = currentEmployee.FirstName + " " + currentEmployee.LastName;
                firstNameBox.Text = currentEmployee.FirstName;
                lastNameBox.Text = currentEmployee.LastName;
                businessPhoneBox.Text = currentEmployee.BusinessPhone;
                mobilePhoneBox.Text = currentEmployee.MobilePhone;
                homePhoneBox.Text = currentEmployee.HomePhone;
                faxNumberBox.Text = currentEmployee.FaxNumber;
                streetBox.Text = currentEmployee.Address;
                cityBox.Text = currentEmployee.City;
                zipPostalCodeBox.Text = currentEmployee.ZIP_PostalCode;
                emailBox.Text = currentEmployee.EmailAddress;
                webPageBox.Text = currentEmployee.WebPage;
                notesBox.Text = currentEmployee.Notes;
                employeeOrders.DataSource = null;

                for (int x = 0; x < stateProvinceBox.Items.Count; x++)
                    if (((Subregion)stateProvinceBox.Items[x]).ID == currentEmployee.State_Province)
                        stateProvinceBox.SelectedIndex = x;

                for (int x = 0; x < countryRegionBox.Items.Count; x++)
                    if (((Objects.Region)countryRegionBox.Items[x]).ID == currentEmployee.Country_Region)
                        countryRegionBox.SelectedIndex = x;

                for (int x = 0; x < jobTitleBox.Items.Count; x++)
                    if (((Objects.JobTitle)jobTitleBox.Items[x]).ID == currentEmployee.JobTitle)
                        jobTitleBox.SelectedIndex = x;

                newEmployee = false;
            }
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool failure = false;
            if (newEmployee) currentEmployee = new Employee();
            currentEmployee.Address = streetBox.Text;
            currentEmployee.BusinessPhone = businessPhoneBox.Text;
            currentEmployee.City = cityBox.Text;
            if (countryRegionBox.SelectedItem != null)
                currentEmployee.Country_Region = ((Objects.Region)countryRegionBox.SelectedItem).ID;
            currentEmployee.EmailAddress = emailBox.Text;
            currentEmployee.FaxNumber = faxNumberBox.Text;
            currentEmployee.FirstName = firstNameBox.Text;
            currentEmployee.HomePhone = homePhoneBox.Text;
            if (jobTitleBox.SelectedItem != null)
                currentEmployee.JobTitle = ((Objects.JobTitle)jobTitleBox.SelectedItem).ID;
            currentEmployee.LastName = lastNameBox.Text;
            currentEmployee.MobilePhone = mobilePhoneBox.Text;
            currentEmployee.Notes = notesBox.Text;
            if (stateProvinceBox.SelectedItem != null)
                currentEmployee.State_Province = ((Northwind.Objects.Subregion)stateProvinceBox.SelectedItem).ID;
            currentEmployee.WebPage = webPageBox.Text;
            currentEmployee.ZIP_PostalCode = zipPostalCodeBox.Text;


            if (failure)
            {
                MessageBox.Show("Errors in data, please revise.");
                return;
            }

            if (newEmployee)
            {
                int Employee = Home.NorthwindDatabase.Context.Insert<Employee>("employees", currentEmployee)
                    .AutoMap(x => x.ID)
                    .ExecuteReturnLastId<int>();
                loadEmployee(Employee);
                MessageBox.Show("Created!");
            }
            else
            {
                Home.NorthwindDatabase.Context.Update<Employee>("employees", currentEmployee)
                    .AutoMap(x => x.ID)
                    .Where(x => x.ID)
                    .Execute();

                loadEmployee(currentEmployee.ID);
                MessageBox.Show("Saved!");
            }
        }

        private void newLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadEmployee(0);
        }
    }
}
