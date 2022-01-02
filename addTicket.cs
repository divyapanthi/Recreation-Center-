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
    public partial class AddTicket : UserControl
    {
        public AddTicket()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TicketPrice ticket = new TicketPrice();
                ticket.Group = comboGroupCount.Text;
                ticket.Duration = int.Parse(comboDuration.Text);
                ticket.Child_weekday = int.Parse(txtChildWeekday.Text);
                ticket.Child_weekend = int.Parse(txtChildWeekend.Text);
                ticket.Adult_weekday = int.Parse(txtAdultWeekday.Text);
                ticket.Adult_weekend = int.Parse(txtAdultWeekend.Text);
                ticket.Add(ticket);
                BindGrid();
            }
            catch (Exception error)
            {
                Console.Write(error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtChildWeekday.Text = "";
            txtChildWeekend.Text = "";
            txtAdultWeekday.Text = "";
            txtAdultWeekend.Text = "";
            comboDuration.SelectedIndex = -1;
            comboDuration.Text = "--Select Duration --";
            comboGroupCount.SelectedIndex = -1;
            comboGroupCount.Text = "--Select Group --";
        }

        public void BindGrid()
        {
            TicketPrice ticket = new TicketPrice();
            List<TicketPrice> listPrice = ticket.List();
            DataTable tableData = Utility.ConvertToDataTable(listPrice);
            PriceDataGridView.DataSource = tableData;

        }

        private void AddTicket_Load(object sender, EventArgs e)
        {
            comboDuration.SelectedIndex = -1;
            comboDuration.Text = "--Select Duration --";
            comboGroupCount.SelectedIndex = -1;
            comboGroupCount.Text = "--Select Group --";
        }
    }
}
