using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_recreation_center
{
    class Visitor
    {
        public Visitor()
        {
        }
        public String VisitorId { get; set; }
        public String VisitorName { get; set; }
        public String PhoneNum { get; set; }
        public String AgeGroup { get; set; }
        public String GroupOf { get; set; }

        public int VisitorsNo { get; set; }
        public String Duration { get; set; }
        public double Price { get; set; }
        public String Date { get; set; }
        public String Day { get; set; }

        public String Status { get; set; }
        public String CheckInTime { get; set; }

        public String CheckOutTime { get; set; }

        public float TicketPrice { get; set; }
     
    }
}
