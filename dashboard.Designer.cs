
namespace cw_recreation_center
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label2 = new System.Windows.Forms.Label();
            this.dashboardBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(208, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 47);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome to Dashboard";
            // 
            // dashboardBox
            // 
            this.dashboardBox.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBox.Image")));
            this.dashboardBox.Location = new System.Drawing.Point(-52, -90);
            this.dashboardBox.Name = "dashboardBox";
            this.dashboardBox.Size = new System.Drawing.Size(939, 845);
            this.dashboardBox.TabIndex = 7;
            this.dashboardBox.TabStop = false;
            this.dashboardBox.Click += new System.EventHandler(this.dashboardBox_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 701);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dashboardBox);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox dashboardBox;
    }
}