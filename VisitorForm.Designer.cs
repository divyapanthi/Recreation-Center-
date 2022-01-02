
namespace cw_recreation_center
{
    partial class VisitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnVisitorList;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weekday = new System.Windows.Forms.RadioButton();
            this.weekend = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioCheckIn = new System.Windows.Forms.RadioButton();
            this.radioCheckOut = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.adult = new System.Windows.Forms.RadioButton();
            this.child = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVisitorId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVisitorsNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            btnVisitorList = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVisitorList
            // 
            btnVisitorList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVisitorList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnVisitorList.Location = new System.Drawing.Point(3, 115);
            btnVisitorList.Name = "btnVisitorList";
            btnVisitorList.Size = new System.Drawing.Size(201, 57);
            btnVisitorList.TabIndex = 8;
            btnVisitorList.Text = "View Visitor List";
            btnVisitorList.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 26);
            this.txtName.TabIndex = 10;
            // 
            // comboGroup
            // 
            this.comboGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Items.AddRange(new object[] {
            "No Group ",
            "Group of 5 ",
            "Group of 10",
            "Group of 15",
            "Group of 20",
            "Group of 30",
            "Group of 50",
            "Group of 100"});
            this.comboGroup.Location = new System.Drawing.Point(133, 288);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(191, 28);
            this.comboGroup.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 49);
            this.label7.TabIndex = 20;
            this.label7.Text = "Visitor\'s Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group of";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Day";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weekday);
            this.groupBox2.Controls.Add(this.weekend);
            this.groupBox2.Location = new System.Drawing.Point(133, 385);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(303, 64);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // weekday
            // 
            this.weekday.AutoSize = true;
            this.weekday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekday.Location = new System.Drawing.Point(12, 23);
            this.weekday.Margin = new System.Windows.Forms.Padding(4);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(111, 25);
            this.weekday.TabIndex = 54;
            this.weekday.Text = "Weekday";
            this.weekday.UseVisualStyleBackColor = true;
            // 
            // weekend
            // 
            this.weekend.AutoSize = true;
            this.weekend.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekend.Location = new System.Drawing.Point(168, 23);
            this.weekend.Margin = new System.Windows.Forms.Padding(4);
            this.weekend.Name = "weekend";
            this.weekend.Size = new System.Drawing.Size(112, 25);
            this.weekend.TabIndex = 22;
            this.weekend.Text = "Weekend";
            this.weekend.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(133, 483);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(326, 28);
            this.dateTimePicker.TabIndex = 45;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(26, 483);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(47, 19);
            this.date.TabIndex = 46;
            this.date.Text = "Date";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(219, 703);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(30, 703);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 47);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(btnVisitorList);
            this.panel1.Controls.Add(this.btnViewReport);
            this.panel1.Location = new System.Drawing.Point(484, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 205);
            this.panel1.TabIndex = 49;
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(3, 31);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(206, 57);
            this.btnViewReport.TabIndex = 7;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioCheckIn);
            this.groupBox3.Controls.Add(this.radioCheckOut);
            this.groupBox3.Location = new System.Drawing.Point(133, 539);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(303, 64);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // radioCheckIn
            // 
            this.radioCheckIn.AutoSize = true;
            this.radioCheckIn.Checked = true;
            this.radioCheckIn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCheckIn.Location = new System.Drawing.Point(11, 23);
            this.radioCheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.radioCheckIn.Name = "radioCheckIn";
            this.radioCheckIn.Size = new System.Drawing.Size(112, 25);
            this.radioCheckIn.TabIndex = 21;
            this.radioCheckIn.TabStop = true;
            this.radioCheckIn.Text = "Check- In";
            this.radioCheckIn.UseVisualStyleBackColor = true;
            // 
            // radioCheckOut
            // 
            this.radioCheckOut.AutoSize = true;
            this.radioCheckOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCheckOut.Location = new System.Drawing.Point(168, 23);
            this.radioCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.radioCheckOut.Name = "radioCheckOut";
            this.radioCheckOut.Size = new System.Drawing.Size(124, 25);
            this.radioCheckOut.TabIndex = 22;
            this.radioCheckOut.Text = "Check-Out";
            this.radioCheckOut.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Status";
            // 
            // adult
            // 
            this.adult.AutoSize = true;
            this.adult.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adult.Location = new System.Drawing.Point(168, 23);
            this.adult.Margin = new System.Windows.Forms.Padding(4);
            this.adult.Name = "adult";
            this.adult.Size = new System.Drawing.Size(76, 25);
            this.adult.TabIndex = 22;
            this.adult.Text = "Adult";
            this.adult.UseVisualStyleBackColor = true;
            // 
            // child
            // 
            this.child.AutoSize = true;
            this.child.Checked = true;
            this.child.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.child.Location = new System.Drawing.Point(11, 23);
            this.child.Margin = new System.Windows.Forms.Padding(4);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(73, 25);
            this.child.TabIndex = 21;
            this.child.TabStop = true;
            this.child.Text = "Child";
            this.child.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.child);
            this.groupBox1.Controls.Add(this.adult);
            this.groupBox1.Location = new System.Drawing.Point(133, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 64);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // txtVisitorId
            // 
            this.txtVisitorId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorId.Location = new System.Drawing.Point(133, 92);
            this.txtVisitorId.Name = "txtVisitorId";
            this.txtVisitorId.Size = new System.Drawing.Size(191, 26);
            this.txtVisitorId.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "Visitor Id";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketPrice.Location = new System.Drawing.Point(145, 624);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(191, 26);
            this.txtTicketPrice.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 627);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ticket Price";
            // 
            // comboDuration
            // 
            this.comboDuration.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "1 hour ",
            "2 hour ",
            "3 hour ",
            "4 hour ",
            "Unlimited"});
            this.comboDuration.Location = new System.Drawing.Point(133, 350);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(191, 28);
            this.comboDuration.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 58;
            this.label11.Text = "Duration";
            // 
            // txtVisitorsNo
            // 
            this.txtVisitorsNo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorsNo.Location = new System.Drawing.Point(468, 285);
            this.txtVisitorsNo.Name = "txtVisitorsNo";
            this.txtVisitorsNo.Size = new System.Drawing.Size(191, 26);
            this.txtVisitorsNo.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "No.of Visitors";
            // 
            // VisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(710, 762);
            this.Controls.Add(this.txtVisitorsNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDuration);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVisitorId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboGroup);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VisitorForm";
            this.Text = "Visitor Form";
            this.TransparencyKey = System.Drawing.Color.MistyRose;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton weekend;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.RadioButton weekday;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioCheckIn;
        private System.Windows.Forms.RadioButton radioCheckOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton adult;
        private System.Windows.Forms.RadioButton child;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVisitorId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVisitorsNo;
        private System.Windows.Forms.Label label1;
    }
}