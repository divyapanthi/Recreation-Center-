using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_recreation_center
{
    class TicketPrice
    {
        public string Group { get; set; }

        public int Duration { get; set; }

        public int Child_weekend { get; set; }

        public int Child_weekday { get; set; }

        public int Adult_weekend { get; set; }

        public int Adult_weekday { get; set; }

        public int Aged_weekend { get; set; }

        public int Aged_weekday { get; set; }

        public void Add(TicketPrice price)
        {

            string data = JsonConvert.SerializeObject(price, Formatting.None);
            Console.WriteLine(data);
            Utility.WriteToText("TicketPrice.json", data);
        }


        public List<TicketPrice> List()
        {
            string text_data = Utility.ReadFromFile("TicketPrice.json");
            if (text_data != null)
            {
                List<TicketPrice> list = JsonConvert.DeserializeObject<List<TicketPrice>>(text_data);
                return list;

            }
            return null;
        }
        public TicketPrice Find(int groupOf, int duration)
        {
            List<TicketPrice> list = List();
            TicketPrice t = list.Where(x => x.Group == groupOf.ToString() && x.Duration == duration).FirstOrDefault();
            return t;

        }
    }
}
