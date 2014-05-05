using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Northwind.Objects;

namespace Northwind
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
            //backdrop.Colors = new[]{Color.FromArgb(180,178,166), Color.FromArgb(212,210,203)};
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            Home.NorthwindDatabase = new Database("localhost", "root", "");
            Home.NorthwindDatabase.Connect();
            employeeBox.Items.AddRange((Home.NorthwindDatabase.Context
                .Sql("SELECT * FROM employees ORDER BY LastName ASC")
                .QueryMany<EmployeeLoginDialog>())
                .ToArray());
            employeeBox.SelectedIndex = 0;
        }

        private void LoginDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.currentEmployee = (Employee)employeeBox.SelectedItem;
        }
    }
}
