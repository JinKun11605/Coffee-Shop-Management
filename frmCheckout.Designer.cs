namespace CoffeeShopManagement
{
    partial class frmCheckout
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
            this.lblCustemerID = new System.Windows.Forms.Label();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Star5 = new System.Windows.Forms.PictureBox();
            this.Star4 = new System.Windows.Forms.PictureBox();
            this.Star3 = new System.Windows.Forms.PictureBox();
            this.Star2 = new System.Windows.Forms.PictureBox();
            this.Star1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustemerID
            // 
            this.lblCustemerID.AutoSize = true;
            this.lblCustemerID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCustemerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustemerID.Location = new System.Drawing.Point(21, 23);
            this.lblCustemerID.Name = "lblCustemerID";
            this.lblCustemerID.Size = new System.Drawing.Size(140, 26);
            this.lblCustemerID.TabIndex = 23;
            this.lblCustemerID.Text = "Khách hàng: ";
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Location = new System.Drawing.Point(158, 506);
            this.btnSendFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(85, 38);
            this.btnSendFeedback.TabIndex = 22;
            this.btnSendFeedback.Text = "Send";
            this.btnSendFeedback.UseVisualStyleBackColor = true;
            this.btnSendFeedback.Click += new System.EventHandler(this.btnSendFeedback_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(565, 540);
            this.btnconfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(237, 113);
            this.btnconfirm.TabIndex = 16;
            this.btnconfirm.Text = "Xác nhận";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Feedback";
            // 
            // txtFeedback
            // 
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtFeedback.Location = new System.Drawing.Point(158, 438);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(1011, 62);
            this.txtFeedback.TabIndex = 14;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(158, 111);
            this.dataGridViewBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.ReadOnly = true;
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.RowTemplate.Height = 24;
            this.dataGridViewBill.Size = new System.Drawing.Size(1011, 235);
            this.dataGridViewBill.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(570, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 67);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Star5
            // 
            this.Star5.BackColor = System.Drawing.Color.Transparent;
            this.Star5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Star5.Location = new System.Drawing.Point(342, 393);
            this.Star5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Star5.Name = "Star5";
            this.Star5.Size = new System.Drawing.Size(39, 40);
            this.Star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star5.TabIndex = 21;
            this.Star5.TabStop = false;
            // 
            // Star4
            // 
            this.Star4.BackColor = System.Drawing.Color.Transparent;
            this.Star4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Star4.Location = new System.Drawing.Point(297, 393);
            this.Star4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Star4.Name = "Star4";
            this.Star4.Size = new System.Drawing.Size(39, 40);
            this.Star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star4.TabIndex = 20;
            this.Star4.TabStop = false;
            // 
            // Star3
            // 
            this.Star3.BackColor = System.Drawing.Color.Transparent;
            this.Star3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Star3.Location = new System.Drawing.Point(250, 393);
            this.Star3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Star3.Name = "Star3";
            this.Star3.Size = new System.Drawing.Size(39, 40);
            this.Star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star3.TabIndex = 19;
            this.Star3.TabStop = false;
            // 
            // Star2
            // 
            this.Star2.BackColor = System.Drawing.Color.Transparent;
            this.Star2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Star2.Location = new System.Drawing.Point(205, 393);
            this.Star2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Star2.Name = "Star2";
            this.Star2.Size = new System.Drawing.Size(39, 40);
            this.Star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star2.TabIndex = 18;
            this.Star2.TabStop = false;
            // 
            // Star1
            // 
            this.Star1.BackColor = System.Drawing.Color.Transparent;
            this.Star1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Star1.Location = new System.Drawing.Point(158, 393);
            this.Star1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Star1.Name = "Star1";
            this.Star1.Size = new System.Drawing.Size(39, 40);
            this.Star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Star1.TabIndex = 17;
            this.Star1.TabStop = false;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 753);
            this.Controls.Add(this.lblCustemerID);
            this.Controls.Add(this.Star5);
            this.Controls.Add(this.Star4);
            this.Controls.Add(this.Star3);
            this.Controls.Add(this.Star2);
            this.Controls.Add(this.Star1);
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.dataGridViewBill);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Star1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustemerID;
        private System.Windows.Forms.PictureBox Star5;
        private System.Windows.Forms.PictureBox Star4;
        private System.Windows.Forms.PictureBox Star3;
        private System.Windows.Forms.PictureBox Star2;
        private System.Windows.Forms.PictureBox Star1;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Label label1;
    }
}