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
    public partial class WeeklyReportGrid : Form
    {
 
            public WeeklyReportGrid()
            {
                InitializeComponent();
                GetDatesOfWeek();
                LoadGrid(Reports());
                comboBox1.SelectedIndex = 0;
            }

            private String StartDate { get; set; }

            private String EndDate { get; set; }

            private void LoadGrid(List<Report> reports)
            {
                dataGridViewVisitor.DataSource = reports;
                dataGridViewVisitor.Columns[0].Width = 200;
                dataGridViewVisitor.Columns[1].Width = 158;
                dataGridViewVisitor.Columns[2].Width = 158;
            }

            private List<Report> Reports()
            {
                string data = VisitorUtility.ReadFromFile();
                List<Visitor> visitorList = JsonConvert.DeserializeObject<List<Visitor>>(data);

                Console.WriteLine(Convert.ToDateTime(StartDate));
                Console.WriteLine(DateTime.Parse(StartDate));
                var groupedData = visitorList.Where(obj => Convert.ToDateTime(obj.Date) >= Convert.ToDateTime(StartDate) &&
                    Convert.ToDateTime(obj.Date) <= Convert.ToDateTime(EndDate)
                ).
                    GroupBy(a => a.Date).Select(
                        n => new {
                            Date = n.Key,
                            TotalVisitors = n.Sum(x => x.VisitorsNo),
                            TotalEarnings = n.Sum(x => x.TicketPrice),
                        }
                    ).OrderBy(a => a.Date).ToList();
                List<Report> reports = new List<Report>();
                foreach (var datas in groupedData)
                {
                    Report report = new Report();
                    report.Date = datas.Date;
                    report.TotalVisitor = datas.TotalVisitors;
                    report.TotalEarning = datas.TotalEarnings;
                    reports.Add(report);
                }
                return reports;
            }

            private void GetDatesOfWeek()
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
                StartDate = startDateOfWeek.ToLongDateString();
                EndDate = endDateOfWeek.ToLongDateString();
                /*Console.WriteLine("Start Of Week: " + startDateOfWeek.ToShortDateString());
                Console.WriteLine("End of week:" + endDateOfWeek.ToShortDateString());*/
            }

            private void DateTimePickerChoose_ValueChanged(object sender, EventArgs e)
            {
                GetDatesOfWeek();
                LoadGrid(Reports());
            }

            private void ComboFilterBySelected_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    FilterByTotalEarningHighToLow();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    FilterByTotalEarningLowToHigh();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    FilterByTotalNumberOfVisitorHighToLow();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    FilterByTotalNumberOfVisitorLowToHigh();
                }

            }

            private void FilterByTotalNumberOfVisitorLowToHigh()
            {
                Report report = new Report();
                List<Report> reportList = report.SortByTotalVisitorsAsc(Reports());
                LoadGrid(reportList);
            }

            private void FilterByTotalNumberOfVisitorHighToLow()
            {
                Report report = new Report();
                List<Report> reportList = report.SortByTotalVisitorsDesc(Reports());
                LoadGrid(reportList);
            }

            private void FilterByTotalEarningLowToHigh()
            {
                Report report = new Report();
                List<Report> reportList = report.SortByTotalEarningAsc(Reports());
                LoadGrid(reportList);
            }

            private void FilterByTotalEarningHighToLow()
            {
                Report report = new Report();
                List<Report> reportList = report.SortByTotalEarningDesc(Reports());
                LoadGrid(reportList);
            }
        }
}
