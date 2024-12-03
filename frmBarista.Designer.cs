namespace CoffeeShopManagement
{
    partial class frmBarista
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnMixing = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.imgLogin);
            this.panel2.Controls.Add(this.guna2PictureBox4);
            this.panel2.Controls.Add(this.guna2PictureBox3);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.btnMixing);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 688);
            this.panel2.TabIndex = 4;
            // 
            // imgLogin
            // 
            this.imgLogin.Image = global::CoffeeShopManagement.Properties.Resources.log_out;
            this.imgLogin.ImageRotate = 0F;
            this.imgLogin.Location = new System.Drawing.Point(11, 599);
            this.imgLogin.Margin = new System.Windows.Forms.Padding(4);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(65, 55);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogin.TabIndex = 17;
            this.imgLogin.TabStop = false;
            this.imgLogin.Click += new System.EventHandler(this.imgLogin_Click);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = global::CoffeeShopManagement.Properties.Resources.barista_icon;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(13, 131);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(67, 53);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 14;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::CoffeeShopManagement.Properties.Resources.id;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(13, 25);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(79, 71);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 13;
            this.guna2PictureBox3.TabStop = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BorderRadius = 10;
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(127, 41);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(276, 55);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Thông tin cá nhân";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnMixing
            // 
            this.btnMixing.BorderRadius = 10;
            this.btnMixing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMixing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMixing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMixing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMixing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMixing.ForeColor = System.Drawing.Color.White;
            this.btnMixing.Location = new System.Drawing.Point(127, 131);
            this.btnMixing.Margin = new System.Windows.Forms.Padding(4);
            this.btnMixing.Name = "btnMixing";
            this.btnMixing.Size = new System.Drawing.Size(276, 55);
            this.btnMixing.TabIndex = 7;
            this.btnMixing.Text = "Pha chế";
            this.btnMixing.Click += new System.EventHandler(this.btnMixing_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 65);
            this.panel1.TabIndex = 3;
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(434, 65);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1048, 688);
            this.pnMain.TabIndex = 5;
            // 
            // frmBarista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBarista";
            this.Text = "frmBarista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox imgLogin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Button btnMixing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMain;
    }
}