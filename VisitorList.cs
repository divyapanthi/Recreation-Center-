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
    public partial class VisitorList : Form
    {
            public VisitorList()
            {
                InitializeComponent();
                LoadGrid();
            }

            private void VisitorsDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void LoadGrid()
            {
            string datas = VisitorUtility.ReadFromFile();
            List<Visitor> list = new List<Visitor>();
            list = JsonConvert.DeserializeObject<List<Visitor>>(datas);
                visitorsDetails.Columns[0].Width = 108;
                visitorsDetails.Columns[1].Width = 108;
                visitorsDetails.Columns[2].Width = 108;
                visitorsDetails.Columns[3].Width = 108;
                visitorsDetails.Columns[4].Width = 108;
                visitorsDetails.Columns[5].Width = 108;
                visitorsDetails.Columns[6].Width = 108;
                visitorsDetails.Columns[7].Width = 108;
                visitorsDetails.Columns[8].Width = 208;
                visitorsDetails.Columns[9].Width = 108;
                visitorsDetails.Columns[10].Width = 108;
                visitorsDetails.Columns[11].Width = 108;
            }
        }
}
