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
    public partial class visitor_form : Form
    {
        public visitor_form()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtVisitorId.Text = null;
            txtName.Text = null;
            child.Checked = false;
            adult.Checked = false;
            comboDuration.SelectedIndex = -1;
            comboDuration.Text = "--Select Duration --";
            weekday.Checked = false;
            weekend.Checked = false;
            radioCheckIn.Checked = false;
            radioCheckOut.Checked = false;
            comboGroup.SelectedIndex = -1;
            comboGroup.Text = "--Select Group --";
            txtTicketPrice.Text = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" ||
                    txtName.Text.Contains("[^0-9]") ||
                    comboGroup.SelectedIndex == 0 ||
                    child.Checked == false ||
                    adult.Checked == false)
                {
                    MessageBox.Show("Some fields are empty. Please enter all the fields!");
                }
                else
                {
                    string id = txtVisitorId.Text;
                    string visitorName = txtName.Text;
                    string group = (string)comboGroup.SelectedItem;
                    string duration = (string)comboDuration.SelectedItem;
                    string ageGroup = "";
                    string day = "";
                    string Status = "";

                    if (child.Checked)
                    {
                        ageGroup = "child";
                    }
                    if (adult.Checked)
                    {
                        ageGroup = "adult";
                    }
                    if (weekend.Checked)
                    {
                        day = "weekday";
                    }
                    if (weekend.Checked)
                    {
                        day = "holiday";
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
                    if (Status.Equals("CHECKEDIN"))
                    {
                        CheckInTime = dateTime.ToShortTimeString();
                    }
                    if (Status.Equals("CHECKEDOUT"))
                    {
                        CheckOutTime = dateTime.ToShortTimeString();
                    }

                    Visitor visitor = new Visitor();
                    visitor.VisitorId = id;
                    visitor.GroupOf = group;
                    visitor.AgeGroup = ageGroup;
                    visitor.Day = day;
                    visitor.Duration = duration;
                    visitor.VisitorName = visitorName;
                    visitor.Date = visitorDate;
                    visitor.CheckInTime = CheckInTime;
                    visitor.CheckOutTime = CheckOutTime;
                    visitor.Status = Status;


                    MessageBox.Show("Visitor Added Successfully!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

     

    
    }
}
