using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_recreation_center
{
    class Ticket { 
    public Ticket()
    {
    }
    public String Id { get; set; }

    public String AgeGroup { get; set; }

    public String Duration { get; set; }
    public String Day { get; set; }

    public String Group { get; set; }

    public float TicketPrice { get; set; }
    public void Run()
    {
        Console.WriteLine(Id);
        Console.WriteLine(Duration);
        Console.WriteLine(Day);
        Console.WriteLine(Group);
        Console.WriteLine(AgeGroup);
    }
}
      
}
