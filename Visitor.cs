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
        public int VisitorId { get; set; }
        public String VisitorName { get; set; }
        public String PhoneNum { get; set; }
        public String AgeGroup { get; set; }
        public int GroupOf { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public String CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }


        public void Add(Visitor visitor)
        {
            string data = JsonConvert.SerializeObject(visitor, Formatting.None);
            Console.WriteLine(data);
            Utility.WriteToText("VisitorDetails.json", data);
        }

        public List<Visitor> List()
        {
            string d = Utility.ReadFromFile("VisitorDetails.json");
            if (d != null)
            {
                List<Visitor> list = JsonConvert.DeserializeObject<List<Visitor>>(d);
                return list;
            }
            return null;
        }
    }
}
