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
    public partial class ticket_form : Form
    {
        public ticket_form()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PriceDataGridView.Rows.Add(comboGroupCount.Text, comboDuration.Text, txtChildWeekday.Text, txtChildWeekend.Text, txtAdultWeekday.Text, txtAdultWeekend.Text, txtAgedWeekday.Text, txtAgedWeekend.Text);

        }

    }
}
