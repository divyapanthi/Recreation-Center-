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
    public partial class ViewReport : UserControl
    {
        public ViewReport()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void LoadGrid()
        {
            string data = VisitorUtility.ReadFromFile();
            List<Visitor> visitorList = JsonConvert.DeserializeObject<List<Visitor>>(data);

            var groupedData = visitorList.Where(a => a.Date == (dateTimePickerChoose.Value.ToLongDateString())).
                GroupBy(a => new { a.AgeGroup, a.GroupOf }).Select(
                    n => new {
                        Date = dateTimePickerChoose.Value.ToLongDateString(),
                        AgeGroup = n.Key.AgeGroup,
                        Group = n.Key.GroupOf,
                        TotalVisitors = n.Sum(x => x.VisitorsNo),
                        TotalEarnings = n.Sum(x => x.TicketPrice),
                    }
                ).OrderBy(a => a.AgeGroup).ToList();
            dataGridViewVisitor.DataSource = groupedData;
            dataGridViewVisitor.Columns[0].Width = 200;
            dataGridViewVisitor.Columns[1].Width = 158;
            dataGridViewVisitor.Columns[2].Width = 158;
            dataGridViewVisitor.Columns[3].Width = 158;
        }

        private void DateTimePickerChoose_ValueChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
