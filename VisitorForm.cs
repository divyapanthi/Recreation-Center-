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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPhoneNum.Clear();
            comboGroup.SelectedIndex = 0;
            child.Checked = false;
            adult.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" ||
                    txtName.Text.Contains("[^0-9]") ||
                    txtPhoneNum.Text == "" ||
                    comboGroup.SelectedIndex == 0 ||
                    child.Checked == false ||
                    adult.Checked == false)
                {
                    MessageBox.Show("Some fields are empty. Please enter all the fields!");
                }
                else
                {
                    int visitorID;
                    Visitor visitor = new Visitor();
                    List<Visitor> listRC = visitor.List();
                    if (listRC == null || listRC.Count == 0)
                    {
                        visitorID = 1;

                    }
                    else { visitorID = listRC.Count + 1; }

                    string checkInTime = DateTime.Now.ToString();
                    string name = txtName.Text;
                    int ageGroup = comboGroup.SelectedIndex;
                    if (child.Checked)
                    {
                        visitor.AgeGroup = "Child";
                    }
                    else if (ageGroup == 2)
                    {
                        visitor.AgeGroup = "Adult";
                    }

                    visitor.VisitorId = visitorID;
                    visitor.VisitorName = txtName.Text;
                    visitor.PhoneNum = txtPhoneNum.Text;
                    visitor.Date = visitorCheckinDate.Value.Date;
                    visitor.CheckInTime = checkInTime;
                    visitor.GroupOf = int.Parse(comboGroup.Text);
                    visitor.Add(visitor);


                    MessageBox.Show("Visitor Added Successfully!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }

        private void viewVisitorList_Click(object sender, EventArgs e)
        {

        }
    }
}
