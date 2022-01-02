
namespace cw_recreation_center
{
    partial class visitor_form
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
            System.Windows.Forms.Button viewVisitorList;
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.child = new System.Windows.Forms.RadioButton();
            this.adult = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weekend = new System.Windows.Forms.RadioButton();
            this.weekday = new System.Windows.Forms.RadioButton();
            this.visitorCheckinDate = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTicket = new System.Windows.Forms.Button();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            viewVisitorList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewVisitorList
            // 
            viewVisitorList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            viewVisitorList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewVisitorList.Location = new System.Drawing.Point(3, 115);
            viewVisitorList.Name = "viewVisitorList";
            viewVisitorList.Size = new System.Drawing.Size(201, 57);
            viewVisitorList.TabIndex = 8;
            viewVisitorList.Text = "View Visitor List";
            viewVisitorList.UseVisualStyleBackColor = false;
            viewVisitorList.Click += new System.EventHandler(this.viewVisitorList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 26);
            this.txtName.TabIndex = 10;
            // 
            // comboGroup
            // 
            this.comboGroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Items.AddRange(new object[] {
            "-Select Group-",
            "1",
            "5",
            "10",
            "15",
            "20"});
            this.comboGroup.Location = new System.Drawing.Point(133, 295);
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
            this.label5.Location = new System.Drawing.Point(26, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Group of";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.child);
            this.groupBox1.Controls.Add(this.adult);
            this.groupBox1.Location = new System.Drawing.Point(133, 204);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(303, 64);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Day";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weekend);
            this.groupBox2.Controls.Add(this.weekday);
            this.groupBox2.Location = new System.Drawing.Point(133, 349);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(303, 64);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // weekend
            // 
            this.weekend.AutoSize = true;
            this.weekend.Checked = true;
            this.weekend.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekend.Location = new System.Drawing.Point(11, 23);
            this.weekend.Margin = new System.Windows.Forms.Padding(4);
            this.weekend.Name = "weekend";
            this.weekend.Size = new System.Drawing.Size(112, 25);
            this.weekend.TabIndex = 21;
            this.weekend.TabStop = true;
            this.weekend.Text = "Weekend";
            this.weekend.UseVisualStyleBackColor = true;
            // 
            // weekday
            // 
            this.weekday.AutoSize = true;
            this.weekday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekday.Location = new System.Drawing.Point(168, 23);
            this.weekday.Margin = new System.Windows.Forms.Padding(4);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(111, 25);
            this.weekday.TabIndex = 22;
            this.weekday.Text = "Weekday";
            this.weekday.UseVisualStyleBackColor = true;
            // 
            // visitorCheckinDate
            // 
            this.visitorCheckinDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorCheckinDate.Location = new System.Drawing.Point(133, 447);
            this.visitorCheckinDate.Margin = new System.Windows.Forms.Padding(4);
            this.visitorCheckinDate.Name = "visitorCheckinDate";
            this.visitorCheckinDate.Size = new System.Drawing.Size(326, 28);
            this.visitorCheckinDate.TabIndex = 45;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(26, 447);
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
            this.btnClear.Location = new System.Drawing.Point(165, 540);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 48;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(30, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 47);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(viewVisitorList);
            this.panel1.Controls.Add(this.btnAddTicket);
            this.panel1.Location = new System.Drawing.Point(506, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 205);
            this.panel1.TabIndex = 49;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(3, 31);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.Size = new System.Drawing.Size(206, 57);
            this.btnAddTicket.TabIndex = 7;
            this.btnAddTicket.Text = "View Report";
            this.btnAddTicket.UseVisualStyleBackColor = false;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(133, 157);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(191, 26);
            this.txtPhoneNum.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Phone";
            // 
            // visitor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(718, 675);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.date);
            this.Controls.Add(this.visitorCheckinDate);
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
            this.Name = "visitor_form";
            this.Text = "Visitor Form";
            this.TransparencyKey = System.Drawing.Color.MistyRose;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton child;
        private System.Windows.Forms.RadioButton adult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton weekend;
        private System.Windows.Forms.RadioButton weekday;
        private System.Windows.Forms.DateTimePicker visitorCheckinDate;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTicket;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label label1;
    }
}