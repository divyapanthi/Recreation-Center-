
namespace cw_recreation_center
{
    partial class AddTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketPriceTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.weekday = new System.Windows.Forms.RadioButton();
            this.holiday = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.child = new System.Windows.Forms.RadioButton();
            this.adult = new System.Windows.Forms.RadioButton();
            this.groupTxt = new System.Windows.Forms.ComboBox();
            this.durationTxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketId = new System.Windows.Forms.Label();
            this.ticketIdText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Price";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(310, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 47);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(446, 443);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 39);
            this.label2.TabIndex = 56;
            this.label2.Text = "TicketPrice";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ticketPriceTxt
            // 
            this.ticketPriceTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketPriceTxt.Location = new System.Drawing.Point(240, 383);
            this.ticketPriceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ticketPriceTxt.Multiline = true;
            this.ticketPriceTxt.Name = "ticketPriceTxt";
            this.ticketPriceTxt.Size = new System.Drawing.Size(293, 38);
            this.ticketPriceTxt.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weekday);
            this.groupBox1.Controls.Add(this.holiday);
            this.groupBox1.Location = new System.Drawing.Point(240, 245);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(295, 59);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // weekday
            // 
            this.weekday.AutoSize = true;
            this.weekday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekday.Location = new System.Drawing.Point(8, 16);
            this.weekday.Margin = new System.Windows.Forms.Padding(4);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(111, 25);
            this.weekday.TabIndex = 10;
            this.weekday.Text = "Weekday";
            this.weekday.UseVisualStyleBackColor = true;
            // 
            // holiday
            // 
            this.holiday.AutoSize = true;
            this.holiday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holiday.Location = new System.Drawing.Point(196, 23);
            this.holiday.Margin = new System.Windows.Forms.Padding(4);
            this.holiday.Name = "holiday";
            this.holiday.Size = new System.Drawing.Size(92, 25);
            this.holiday.TabIndex = 9;
            this.holiday.Text = "Holiday";
            this.holiday.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.child);
            this.groupBox2.Controls.Add(this.adult);
            this.groupBox2.Location = new System.Drawing.Point(241, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(293, 46);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            // 
            // child
            // 
            this.child.AutoSize = true;
            this.child.Checked = true;
            this.child.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.child.Location = new System.Drawing.Point(8, 14);
            this.child.Margin = new System.Windows.Forms.Padding(4);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(170, 25);
            this.child.TabIndex = 6;
            this.child.TabStop = true;
            this.child.Text = "Child( 5 to 12 yrs)";
            this.child.UseVisualStyleBackColor = true;
            // 
            // adult
            // 
            this.adult.AutoSize = true;
            this.adult.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adult.Location = new System.Drawing.Point(205, 14);
            this.adult.Margin = new System.Windows.Forms.Padding(4);
            this.adult.Name = "adult";
            this.adult.Size = new System.Drawing.Size(76, 25);
            this.adult.TabIndex = 7;
            this.adult.Text = "Adult";
            this.adult.UseVisualStyleBackColor = true;
            // 
            // groupTxt
            // 
            this.groupTxt.AutoCompleteCustomSource.AddRange(new string[] {
            "No Group",
            "Group of 5 ",
            "Group of 10",
            "Group of 15 ",
            "Group of 20",
            "Group of 25 ",
            "Group of 30",
            "Group of 50",
            "Group of 100"});
            this.groupTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTxt.FormattingEnabled = true;
            this.groupTxt.Items.AddRange(new object[] {
            "No Group",
            "Group of 5 ",
            "Group of 10",
            "Group of 15 ",
            "Group of 20",
            "Group of 25 ",
            "Group of 30",
            "Group of 50",
            "Group of 100"});
            this.groupTxt.Location = new System.Drawing.Point(240, 320);
            this.groupTxt.Margin = new System.Windows.Forms.Padding(4);
            this.groupTxt.Name = "groupTxt";
            this.groupTxt.Size = new System.Drawing.Size(293, 29);
            this.groupTxt.TabIndex = 52;
            this.groupTxt.Text = "-- Select Group --";
            // 
            // durationTxt
            // 
            this.durationTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.durationTxt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationTxt.FormattingEnabled = true;
            this.durationTxt.Items.AddRange(new object[] {
            "1 hour ",
            "2 hour ",
            "3 hour ",
            "4 hour ",
            "Unlimited"});
            this.durationTxt.Location = new System.Drawing.Point(240, 199);
            this.durationTxt.Margin = new System.Windows.Forms.Padding(4);
            this.durationTxt.Name = "durationTxt";
            this.durationTxt.Size = new System.Drawing.Size(293, 29);
            this.durationTxt.TabIndex = 51;
            this.durationTxt.Text = "-- Duration --";
            this.durationTxt.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 39);
            this.label4.TabIndex = 50;
            this.label4.Text = "Age Group:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 39);
            this.label3.TabIndex = 49;
            this.label3.Text = "Duration:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dayLabel
            // 
            this.dayLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(33, 245);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(135, 39);
            this.dayLabel.TabIndex = 48;
            this.dayLabel.Text = "Day:";
            this.dayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 39);
            this.label5.TabIndex = 47;
            this.label5.Text = "Group:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ticketId
            // 
            this.ticketId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketId.Location = new System.Drawing.Point(33, 79);
            this.ticketId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ticketId.Name = "ticketId";
            this.ticketId.Size = new System.Drawing.Size(135, 39);
            this.ticketId.TabIndex = 46;
            this.ticketId.Text = "Ticket Id:";
            this.ticketId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ticketIdText
            // 
            this.ticketIdText.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketIdText.Location = new System.Drawing.Point(240, 79);
            this.ticketIdText.Margin = new System.Windows.Forms.Padding(4);
            this.ticketIdText.Multiline = true;
            this.ticketIdText.Name = "ticketIdText";
            this.ticketIdText.Size = new System.Drawing.Size(293, 38);
            this.ticketIdText.TabIndex = 45;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketPriceTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupTxt);
            this.Controls.Add(this.durationTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ticketId);
            this.Controls.Add(this.ticketIdText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "AddTicket";
            this.Size = new System.Drawing.Size(617, 589);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ticketPriceTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton weekday;
        private System.Windows.Forms.RadioButton holiday;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton child;
        private System.Windows.Forms.RadioButton adult;
        private System.Windows.Forms.ComboBox groupTxt;
        private System.Windows.Forms.ComboBox durationTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ticketId;
        private System.Windows.Forms.TextBox ticketIdText;
    }
}
