using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_recreation_center
{
    class Report
    {
        public String Date { get; set; }

        public int TotalVisitor { get; set; }

        public float TotalEarning { get; set; }

        public List<Report> SortByTotalEarningAsc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].TotalEarning.CompareTo(reports[j].TotalEarning) > 0)
                        {
                            Report tempReport = reports[i];
                            reports[i] = reports[j];
                            reports[j] = tempReport;
                        }
                    }
                }
                return reports;
            }
            return null;
        }

        public List<Report> SortByTotalEarningDesc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].TotalEarning.CompareTo(reports[j].TotalEarning) < 0)
                        {
                            Report tempReport = reports[i];
                            reports[i] = reports[j];
                            reports[j] = tempReport;
                        }
                    }
                }
                return reports;
            }
            return null;
        }
        public List<Report> SortByTotalVisitorsAsc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].TotalVisitor.CompareTo(reports[j].TotalVisitor) > 0)
                        {

                            Report tempReport = reports[i];
                            reports[i] = reports[j];
                            reports[j] = tempReport;

                        }
                    }
                }
                return reports;
            }
            return null;
        }
        public List<Report> SortByTotalVisitorsDesc(List<Report> reports)
        {
            if (reports != null)
            {
                for (int i = 0; i < reports.Count - 1; i++)
                {
                    for (int j = i + 1; j < reports.Count; j++)
                    {
                        if (reports[i].TotalVisitor.CompareTo(reports[j].TotalVisitor) < 0)
                        {

                            Report tempReport = reports[i];
                            reports[i] = reports[j];
                            reports[j] = tempReport;
                        }
                    }
                }
                return reports;
            }
            return null;
        }

    }

}
