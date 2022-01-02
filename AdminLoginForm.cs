using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw_recreation_center
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text; // fetching data from username field
            string password = txtPassword.Text; // fetching data form password field 

            // setting and validating username and password for admin

            if (username == "admin" && password == "admin")
            {
                AdminDashboard dashboard = new AdminDashboard(); // navigating to admin panel window
                dashboard.Show();

            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }


    }
}
