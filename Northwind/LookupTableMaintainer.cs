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
    public partial class LookupTableMaintainer : Form
    {
        public LookupTableMaintainer()
        {
            InitializeComponent();
        }

        private void LookupTableMaintainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void LookupTableMaintainer_Load(object sender, EventArgs e)
        {
            tablesBox.SelectedIndex = 0;

            valuesBox.DataSource = Home.NorthwindDatabase.Context
                    .Sql("SELECT * FROM `category` ORDER BY `Name`;")
                    .QueryMany<Category>();
        }

        private void tablesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tablesBox.SelectedIndex)
            {
                case 0:
                    valuesBox.DataSource = Home.NorthwindDatabase.Context
                            .Sql("SELECT * FROM `category` ORDER BY `Name`;")
                            .QueryMany<Category>();
                    break;
                case 1:
                    valuesBox.DataSource = Home.NorthwindDatabase.Context
                            .Sql("SELECT * FROM `region` ORDER BY `Name`;")
                            .QueryMany<Objects.Region>();
                    break;
                case 2:
                    valuesBox.DataSource = Home.NorthwindDatabase.Context
                            .Sql("SELECT * FROM `jobtitle` ORDER BY `Name`;")
                            .QueryMany<JobTitle>();
                    break;
                case 3:
                    valuesBox.DataSource = Home.NorthwindDatabase.Context
                            .Sql("SELECT * FROM `subregion` ORDER BY `Name`;")
                            .QueryMany<Subregion>();
                    break;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            switch (tablesBox.SelectedIndex)
            {
                case 0:
                    Home.NorthwindDatabase.Context
                            .Sql("DELETE FROM `category` WHERE `ID`=" + ((Category)valuesBox.SelectedItem).ID)
                            .Execute();
                    break;
                case 1:
                    Home.NorthwindDatabase.Context
                            .Sql("DELETE FROM `region` WHERE `ID`=" + ((Objects.Region)valuesBox.SelectedItem).ID)
                            .Execute();
                    break;
                case 2:
                    Home.NorthwindDatabase.Context
                            .Sql("DELETE FROM `jobtitle` WHERE `ID`=" + ((JobTitle)valuesBox.SelectedItem).ID)
                            .Execute();
                    break;
                case 3:
                    Home.NorthwindDatabase.Context
                            .Sql("DELETE FROM `subregion` WHERE `ID`=" + ((Subregion)valuesBox.SelectedItem).ID)
                            .Execute();
                    break;
            }
            tablesBox_SelectedIndexChanged(sender, e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch(tablesBox.SelectedIndex)
            {
                case 0:
                    Home.NorthwindDatabase.Context
                            .Sql("INSERT INTO `category` (`Name`) VALUES ('" + addBox.Text + "')")
                            .Execute();
                    break;
                case 1:
                    Home.NorthwindDatabase.Context
                            .Sql("INSERT INTO `region` (`Name`) VALUES ('" + addBox.Text + "')")
                            .Execute();
                    break;
                case 2:
                    Home.NorthwindDatabase.Context
                            .Sql("INSERT INTO `jobtitle` (`Name`) VALUES ('" + addBox.Text + "')")
                            .Execute();
                    break;
                case 3:
                    Home.NorthwindDatabase.Context
                            .Sql("INSERT INTO `subregion` (`Name`) VALUES ('" + addBox.Text + "')")
                            .Execute();
                    break;
            }
            tablesBox_SelectedIndexChanged(sender, e);
        }
    }
}
