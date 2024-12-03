namespace CoffeeShopManagement
{
    partial class frmReportSales
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
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnDoanhthu = new System.Windows.Forms.Button();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "dd/MM/yyyy";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(419, 156);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(118, 22);
            this.dtpStartTime.TabIndex = 24;
            this.dtpStartTime.UseWaitCursor = true;
            this.dtpStartTime.Value = new System.DateTime(2024, 11, 21, 0, 0, 0, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "dd/MM/yyyy";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(608, 156);
            this.dtpEndTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(115, 22);
            this.dtpEndTime.TabIndex = 25;
            this.dtpEndTime.UseWaitCursor = true;
            this.dtpEndTime.Value = new System.DateTime(2024, 11, 29, 0, 0, 0, 0);
            // 
            // btnDoanhthu
            // 
            this.btnDoanhthu.Location = new System.Drawing.Point(466, 410);
            this.btnDoanhthu.Name = "btnDoanhthu";
            this.btnDoanhthu.Size = new System.Drawing.Size(174, 49);
            this.btnDoanhthu.TabIndex = 26;
            this.btnDoanhthu.Text = "Xem Doanh Thu";
            this.btnDoanhthu.UseVisualStyleBackColor = true;
            this.btnDoanhthu.Click += new System.EventHandler(this.btnDoanhthu_Click);
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(459, 277);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(183, 78);
            this.lblDoanhThu.TabIndex = 27;
            this.lblDoanhThu.Text = "Doanh thu:\r\n\r\n";
            // 
            // frmReportSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.btnDoanhthu);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Name = "frmReportSales";
            this.Size = new System.Drawing.Size(1186, 688);
            this.Load += new System.EventHandler(this.frmReportSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button btnDoanhthu;
        private System.Windows.Forms.Label lblDoanhThu;
    }
}
