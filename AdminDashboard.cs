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
            openChildForm(new AddTicket());
        }



        private void btnVisitorList_Click(object sender, EventArgs e)
        {
            openChildForm(new VisitorList());

        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(childForm);
            panelDashboard.Tag = childForm;
            panelAddTicket.Controls.Add(childForm);
            panelAddTicket.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private Form activeForm = null;

        private void btnTicketList_Click(object sender, EventArgs e)
        {
            openChildForm(new TicketList());
        }

        private void dailyVisitorReport_Click(object sender, EventArgs e)
        {
            openChildForm(new DailyReport());
        }

        private void weeklyVisitorReport_Click(object sender, EventArgs e)
        {
            openChildForm(new WeeklyReportGrid());
        }

        private void WeeklyVisitorChart_Click(object sender, EventArgs e)
        {
            openChildForm(new WeeklyVisitorChart());
        }
    }
}