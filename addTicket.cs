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
    public partial class AddTicket : Form
    {
            public AddTicket()
            {
                InitializeComponent();
            }

            private void BtnSave_Click(object sender, EventArgs e)
            {
                try
                {
                    string id = ticketIdText.Text;
                    string group = (string)groupTxt.SelectedItem;
                    string duration = (string)durationTxt.SelectedItem;
                    string ageGroup = "";
                    String day = "";
                    if (child.Checked)
                    {
                        ageGroup = "child";
                    }
                    if (adult.Checked)
                    {
                        ageGroup = "adult";
                    }
                    if (weekday.Checked)
                    {
                        day = "weekday";
                    }
                    if (weekend.Checked)
                    {
                        day = "holiday";

                    }
                    Ticket ticket = new Ticket();
                    ticket.Id = id;
                    ticket.Group = group;
                    ticket.AgeGroup = ageGroup;
                    ticket.Day = day;
                    ticket.Duration = duration;
                    VaidationCheck(ticket);
                    MessageBox.Show("Ticket Added Successfully.");


                }
                catch (Exception error)
                {
                    Console.Write(error);
                }
            }


            private void VaidationCheck(Ticket ticket)
            {
                if (!ticket.Id.Equals(""))
                {
                    if (ticket.Duration != null)
                    {
                        if (ticket.Group != null)
                        {
                            if (!ticket.AgeGroup.Equals(""))
                            {
                                if (!ticket.Day.Equals(""))
                                {

                                    if (!ticketPriceTxt.Text.Equals(""))
                                    {
                                        ticket.Run();
                                        string datas = TicketUtility.ReadFromFile();
                                        List<Ticket> ticketList = new List<Ticket>();
                                        if (datas != null && datas != "")
                                        {
                                            ticketList = JsonConvert.DeserializeObject<List<Ticket>>(datas);
                                        }
                                        string ticketPrice = ticketPriceTxt.Text;
                                        float TicketPrice = float.Parse(ticketPrice, CultureInfo.InvariantCulture.NumberFormat);
                                        ticket.TicketPrice = TicketPrice;
                                        ticketList.Add(ticket);
                                        string data = JsonConvert.SerializeObject(ticketList);
                                        TicketUtility.WriteToText(data);
                                        Clear();
                                    }
                                }
                            }
                        }
                    }

                }

            }


            private void Clear()
            {
                ticketIdText.Text = null;
                child.Checked = false;
                adult.Checked = false;
                durationTxt.SelectedIndex = -1;
                durationTxt.Text = "--Select Duration --";
                weekday.Checked = false;
                weekend.Checked = false;
                groupTxt.SelectedIndex = -1;
                groupTxt.Text = "--Select Group --";
            }
            private void BtnClear_Click(object sender, EventArgs e)
            {
                Clear();
            }

 
    }
}
