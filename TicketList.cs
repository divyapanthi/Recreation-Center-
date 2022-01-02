using Newtonsoft.Json;
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
    public partial class TicketList : Form
    {
            public TicketList()
            {
                InitializeComponent();
                LoadGrid();
            }

            private void DataGridViewTicketRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
            private void LoadGrid()
            {
                string datas = TicketUtility.ReadFromFile();
                List<Ticket> ticketList = new List<Ticket>();
                ticketList = JsonConvert.DeserializeObject<List<Ticket>>(datas);
                ticketRates.DataSource = ticketList;
            }
        }
}
