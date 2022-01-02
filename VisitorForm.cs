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
    public partial class VisitorForm : Form
    {
        public VisitorForm()
        {
            InitializeComponent();
        }

      

   

        private void Save_Click(object sender, EventArgs e)
        {
            string id = txtVisitorId.Text;
            string visitorName = txtName.Text;
            string group = (string)comboGroup.SelectedItem;
            string duration = (string)comboDuration.SelectedItem;
            string ageGroup = "";
            string day = "";
            string Status = "";
            
            if (child.Checked) {
                ageGroup = "child";
            }
            if (adult.Checked) {
                ageGroup = "adult";
            }
            if (weekday.Checked) {
                day = "weekday";
            }
            if (weekend.Checked) {
                day = "weekend";
            }
            if (radioCheckIn.Checked)
            {
                Status = "CHECKEDIN";
            }
            if (radioCheckOut.Checked)
            {
                Status = "CHECKEDOUT";
            }
            var dateTime = DateTime.Now;
            var Date = dateTime.ToLongDateString();
            var visitorDate = dateTimePicker.Value.ToLongDateString();
            var CheckInTime = "";
            var CheckOutTime = "";
            if (Status.Equals("CHECKEDIN")) {
                 CheckInTime = dateTime.ToShortTimeString();
            }
            if (Status.Equals("CHECKEDOUT"))
            {
                CheckOutTime = dateTime.ToShortTimeString();
            }

            Visitor visitor = new Visitor();
            visitor.VisitorId=id;
            visitor.GroupOf = group;
            visitor.AgeGroup = ageGroup;
            visitor.Day = day;
            visitor.Duration = duration;
            visitor.VisitorName = visitorName;
            visitor.Date = visitorDate;
            visitor.CheckInTime = CheckInTime;
            visitor.CheckOutTime = CheckOutTime;
            visitor.Status = Status;
            CheckValidation(visitor);
        }

        private void CheckValidation(Visitor visitor) { 
            if (!visitor.VisitorId.Equals(""))
            {
                if (!visitor.VisitorName.Equals(""))
                {
                    if (visitor.GroupOf != null)
                    {
                        if (!visitor.AgeGroup.Equals(""))
                        {
                            Console.WriteLine("asdf+");
                            if (!txtVisitorsNo.Text.Equals(""))
                            {
                                if (visitor.Status.Equals("CHECKEDIN"))
                                {
                                    SaveVisitor(visitor);
                                }
                                else if (visitor.Status.Equals("CHECKEDOUT")){
                                    if(visitor.Duration != null)
                                    {
                                        Console.WriteLine();
                                        if (!txtTicketPrice.Text.Equals("")) {
                                            UpdateVisitor(visitor);
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }

        }

        private void UpdateVisitor(Visitor visitor)
        {
            List<Visitor> visitors= VisitorList();
            Boolean IdChecker = false;
            Boolean Status = false;
            foreach (Visitor visitorInfo in visitors)
            {
                if (visitorInfo.VisitorId.Equals(visitor.VisitorId))
                {
                    if (visitorInfo.Status.Equals("CHECKEDIN"))
                    {
                        visitor.TicketPrice = float.Parse(txtTicketPrice.Text);
                        visitor.Status = "CHECKEDOUT";
                        visitor.CheckInTime = visitorInfo.CheckInTime;
                        visitor.VisitorsNo = visitorInfo.VisitorsNo;
                        visitors.Remove(visitorInfo);
                        visitors.Add(visitor);
                        Write(visitors);
                        IdChecker = false;
                        Status = false;
                        MessageBox.Show("Visitor Added Successfully.");
                    }
                    else
                    {
                        IdChecker = false;
                        Status = true;
                    }
                    break;
                }
                else
                {
                    IdChecker = true;
                }
            }
            if (IdChecker == true) {
                MessageBox.Show("Visitor Has Not Checked In");
                return;
            }
            if (Status == true)
            {
                MessageBox.Show("Visitor Has Already Checked Out");
                return;
            }
        }

        private List<Visitor> VisitorList()
        {
            string datas = VisitorUtility.ReadFromFile();
            List<Visitor> visitors = new List<Visitor>();
            if (datas != null && datas != "")
            {
                visitors = JsonConvert.DeserializeObject<List<Visitor>>(datas);
            }
            return visitors;
        }

        private void SaveVisitor(Visitor visitor)
        {
            List<Visitor> visitors = VisitorList();
            foreach (Visitor visitorInfo in visitors)
            {
                if (visitorInfo.VisitorId.Equals(visitor.VisitorId))
                {
                    MessageBox.Show("   " + "Invalid!" + "\n" + "Id: " + visitor.VisitorId + " is already taken");
                    return;
                }
            }
            string visitorNumber = txtVisitorsNo.Text;
            int NumberOfVisitor = int.Parse(visitorNumber);
            visitor.VisitorsNo = NumberOfVisitor;
            visitors.Add(visitor);
            Write(visitors);
            MessageBox.Show("Visitor Details Saved" + "\n" +
                "VisitorName: " + visitor.VisitorName + "\n" +
                "Age Group: " + visitor.AgeGroup + "\n" +
                "Number oF Visitors: " + visitor.VisitorsNo + "\n" +
                "Visited Date: " + visitor.Date + "\n" +
                "Check In Time: " + visitor.CheckInTime + "\n"
                );
        }

        private void Write(List<Visitor> visitors)
        {
            string data = JsonConvert.SerializeObject(visitors);
            VisitorUtility.WriteToText(data);
        }

        private void visitorListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorList list = new VisitorList();
            list.Show();
        }
        public void Clear() {
            txtVisitorsNo.Text = null;
            txtName.Text = null;
            child.Checked = false;
            adult.Checked = false;
            comboDuration.SelectedIndex=-1;
            comboDuration.Text = "--Select Duration --";
            weekday.Checked = false;
            weekend.Checked = false;
            radioCheckIn.Checked = false;
            radioCheckOut.Checked = false;
            comboGroup.SelectedIndex = -1;
            txtVisitorsNo.Text = "--Select Group --";
            txtVisitorsNo.Text = null;
            txtTicketPrice.Text = null;
        }

        private void ticketListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketList list = new TicketList();
            list.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

     
    }
}
