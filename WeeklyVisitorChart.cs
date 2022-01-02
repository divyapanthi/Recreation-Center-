using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw_recreation_center
{
    public partial class WeeklyVisitorChart : UserControl
    {
        public WeeklyVisitorChart()
        {
            InitializeComponent();
            getDatesOfWeek();
            LoadChart();
        }

        private String startDate { get; set; }

        private String endDate { get; set; }
        public void LoadChart()
        {
            string data = VisitorUtility.ReadFromFile();
            List<Visitor> visitorList = JsonConvert.DeserializeObject<List<Visitor>>(data);
            var groupedData = visitorList.Where(obj => Convert.ToDateTime(obj.Date) >= Convert.ToDateTime(startDate) &&
                Convert.ToDateTime(obj.Date) <= Convert.ToDateTime(endDate)
            ).
                GroupBy(a => a.Date).Select(
                    n => new
                    {
                        Date = n.Key,
                        TotalVisitor = n.Sum(x => x.VisitorsNo),
                        TotalEarning = n.Sum(x => x.TicketPrice),
                    }
                ).OrderBy(a => a.Date);
            weeklyVisitorReportChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            weeklyVisitorReportChart.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            weeklyVisitorReportChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            weeklyVisitorReportChart.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            weeklyVisitorReportChart.Series["Total Earning"].IsValueShownAsLabel = true;
            weeklyVisitorReportChart.Series["Total Earning"].XValueMember = "Date";
            weeklyVisitorReportChart.Series["Total Earning"].YValueMembers = "TotalEarning";
            weeklyVisitorReportChart.Series["Number of Visitors"].IsValueShownAsLabel = true;
            weeklyVisitorReportChart.Series["Number of Visitors"].XValueMember = "Date";
            weeklyVisitorReportChart.Series["Number of Visitors"].YValueMembers = "TotalVisitor";
            weeklyVisitorReportChart.DataSource = groupedData;
        }

        private void getDatesOfWeek()
        {
            DateTime date = dateTimePickerChoose.Value;
            int year = date.Date.Year;
            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);
            //get Day of the week 
            DayOfWeek day = date.DayOfWeek;
            CultureInfo cul = CultureInfo.CurrentCulture;
            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);
            startDate = startDateOfWeek.ToLongDateString();
            endDate = endDateOfWeek.ToLongDateString();
        }

        private void dateTimePickerChoose_ValueChanged(object sender, EventArgs e)
        {
            getDatesOfWeek();
            LoadChart();
        }
    }
}
