using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;
using FluentData;

namespace Northwind
{
    public class Database
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string database;

        public string DatabaseName
        {
            get { return database; }
            set { database = value; }
        }
        private string host;

        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        private int port;

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        private IDbContext context;

        public IDbContext Context
        {
            get { return context; }
            set { context = value; }
        }

        public Database(string host, int port, string database, string username, string password)
        {
            this.host = host;
            this.port = port;
            this.database = database;
            this.username = username;
            this.password = password;
        }

        public Database(string host, string database, string username, string password)
            : this(host, 3306, database, username, password)
        {

        }

        public Database(string host, string username, string password)
            : this(host, "northwind", username, password)
        {

        }

        public IDbContext BuildContext()
        {
            return new DbContext().ConnectionString(GetConnectionString(),new MySqlProvider());
        }

        public string BuildConnectionString(string host, int port, string database, string username, string password)
        {
            return String.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};",host,port,database,username,password);
        }

        public string GetConnectionString()
        {
            return BuildConnectionString(this.host, this.port, this.database, this.username, this.password);
        }

        public void Connect()
        {
            try
            {
                context = BuildContext();
            }
            catch (Exception)
            {
                MessageBox.Show("MySQL server is not running! Error 1001");
                throw;
            }
        }
    }
}
