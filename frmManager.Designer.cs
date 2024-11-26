namespace CoffeeShopManagement
{
    partial class frmManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnBarista = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1782, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnInventory);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnCustomer);
            this.panel2.Controls.Add(this.btnBarista);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.btnDashBoard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 688);
            this.panel2.TabIndex = 1;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(39, 515);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(152, 47);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(39, 618);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(152, 47);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(39, 410);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(152, 47);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBarista
            // 
            this.btnBarista.Location = new System.Drawing.Point(39, 303);
            this.btnBarista.Name = "btnBarista";
            this.btnBarista.Size = new System.Drawing.Size(152, 47);
            this.btnBarista.TabIndex = 2;
            this.btnBarista.Text = "Barista";
            this.btnBarista.UseVisualStyleBackColor = true;
            this.btnBarista.Click += new System.EventHandler(this.btnBarista_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(39, 189);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(152, 47);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Information";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(39, 86);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(152, 47);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // pnMain
            // 
            this.pnMain.AutoSize = true;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(232, 65);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1550, 688);
            this.pnMain.TabIndex = 2;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 753);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnBarista;
        private System.Windows.Forms.Button btnInfo;
    }
}