
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
            this.PriceDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAdultWeekday = new System.Windows.Forms.TextBox();
            this.txtAdultWeekend = new System.Windows.Forms.TextBox();
            this.txtChildWeekday = new System.Windows.Forms.TextBox();
            this.txtChildWeekend = new System.Windows.Forms.TextBox();
            this.comboDuration = new System.Windows.Forms.ComboBox();
            this.comboGroupCount = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceDataGridView
            // 
            this.PriceDataGridView.BackgroundColor = System.Drawing.Color.Azure;
            this.PriceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceDataGridView.GridColor = System.Drawing.Color.CornflowerBlue;
            this.PriceDataGridView.Location = new System.Drawing.Point(16, 282);
            this.PriceDataGridView.Name = "PriceDataGridView";
            this.PriceDataGridView.RowHeadersWidth = 51;
            this.PriceDataGridView.RowTemplate.Height = 24;
            this.PriceDataGridView.Size = new System.Drawing.Size(778, 309);
            this.PriceDataGridView.TabIndex = 35;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(457, 212);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 47);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtAdultWeekday
            // 
            this.txtAdultWeekday.Location = new System.Drawing.Point(608, 163);
            this.txtAdultWeekday.Name = "txtAdultWeekday";
            this.txtAdultWeekday.Size = new System.Drawing.Size(100, 22);
            this.txtAdultWeekday.TabIndex = 32;
            // 
            // txtAdultWeekend
            // 
            this.txtAdultWeekend.Location = new System.Drawing.Point(474, 164);
            this.txtAdultWeekend.Name = "txtAdultWeekend";
            this.txtAdultWeekend.Size = new System.Drawing.Size(100, 22);
            this.txtAdultWeekend.TabIndex = 31;
            // 
            // txtChildWeekday
            // 
            this.txtChildWeekday.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildWeekday.Location = new System.Drawing.Point(608, 106);
            this.txtChildWeekday.Name = "txtChildWeekday";
            this.txtChildWeekday.Size = new System.Drawing.Size(100, 23);
            this.txtChildWeekday.TabIndex = 29;
            // 
            // txtChildWeekend
            // 
            this.txtChildWeekend.Location = new System.Drawing.Point(474, 106);
            this.txtChildWeekend.Name = "txtChildWeekend";
            this.txtChildWeekend.Size = new System.Drawing.Size(100, 22);
            this.txtChildWeekend.TabIndex = 28;
            // 
            // comboDuration
            // 
            this.comboDuration.FormattingEnabled = true;
            this.comboDuration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "4+"});
            this.comboDuration.Location = new System.Drawing.Point(170, 161);
            this.comboDuration.Name = "comboDuration";
            this.comboDuration.Size = new System.Drawing.Size(121, 24);
            this.comboDuration.TabIndex = 27;
            // 
            // comboGroupCount
            // 
            this.comboGroupCount.FormattingEnabled = true;
            this.comboGroupCount.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20"});
            this.comboGroupCount.Location = new System.Drawing.Point(170, 104);
            this.comboGroupCount.Name = "comboGroupCount";
            this.comboGroupCount.Size = new System.Drawing.Size(121, 24);
            this.comboGroupCount.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(362, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Child";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Adult";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Weekend";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Weekday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Group Count";
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Brown;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(608, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 47);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Age Group";
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.PriceDataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdultWeekday);
            this.Controls.Add(this.txtAdultWeekend);
            this.Controls.Add(this.txtChildWeekday);
            this.Controls.Add(this.txtChildWeekend);
            this.Controls.Add(this.comboDuration);
            this.Controls.Add(this.comboGroupCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTicket";
            this.Size = new System.Drawing.Size(826, 617);
            this.Load += new System.EventHandler(this.AddTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PriceDataGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAdultWeekday;
        private System.Windows.Forms.TextBox txtAdultWeekend;
        private System.Windows.Forms.TextBox txtChildWeekday;
        private System.Windows.Forms.TextBox txtChildWeekend;
        private System.Windows.Forms.ComboBox comboDuration;
        private System.Windows.Forms.ComboBox comboGroupCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
    }
}
