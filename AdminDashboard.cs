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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            main obj = new main();
            obj.Show();
            this.Hide();
        }

        private void BtnAddTicket_Click(object sender, EventArgs e)
        {
            SetActivePanel(addTicket1);
        }

        public void SetActivePanel(UserControl userControl) {
            dashboard1.Visible = false;
            addTicket1.Visible = false;
            userControl.Visible = true;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            SetActivePanel(dashboard1);
        }

        private void btnVisitorList_Click(object sender, EventArgs e)
        {

        }
    }
}
