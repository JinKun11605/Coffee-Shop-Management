namespace CoffeeShopManagement
{
    partial class frmCustomerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Hạng";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(253, 164);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(105, 26);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(253, 47);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(107, 26);
            this.txtFullName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày sinh";
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDay.Location = new System.Drawing.Point(253, 99);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.ShowUpDown = true;
            this.dtpBirthDay.Size = new System.Drawing.Size(107, 26);
            this.dtpBirthDay.TabIndex = 23;
            this.dtpBirthDay.UseWaitCursor = true;
            this.dtpBirthDay.Value = new System.DateTime(2024, 11, 21, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLevel);
            this.groupBox1.Controls.Add(this.dtpBirthDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.groupBox1.Size = new System.Drawing.Size(400, 297);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // cbLevel
            // 
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "Đồng",
            "Bạc ",
            "Vàng",
            "Bạch Kim",
            "Kim Cương"});
            this.cbLevel.Location = new System.Drawing.Point(253, 228);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(107, 28);
            this.cbLevel.TabIndex = 40;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.BirthDay,
            this.PhoneNumber,
            this.CustomerLevel,
            this.ID,
            this.Password});
            this.dgvCustomer.Location = new System.Drawing.Point(107, 503);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(803, 240);
            this.dgvCustomer.TabIndex = 28;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick_1);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FullName.DefaultCellStyle = dataGridViewCellStyle1;
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // BirthDay
            // 
            this.BirthDay.DataPropertyName = "BirthDay";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BirthDay.DefaultCellStyle = dataGridViewCellStyle2;
            this.BirthDay.HeaderText = "Ngày sinh";
            this.BirthDay.MinimumWidth = 6;
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Width = 120;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 150;
            // 
            // CustomerLevel
            // 
            this.CustomerLevel.DataPropertyName = "CustomerLevel";
            this.CustomerLevel.HeaderText = "Hạng";
            this.CustomerLevel.MinimumWidth = 6;
            this.CustomerLevel.Name = "CustomerLevel";
            this.CustomerLevel.Width = 125;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.ID.HeaderText = "Tài khoản";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 120;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Password.DefaultCellStyle = dataGridViewCellStyle5;
            this.Password.HeaderText = "Mật khẩu";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 120;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 119);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(102, 26);
            this.txtPassword.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tài khoản";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(189, 51);
            this.txtID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(102, 26);
            this.txtID.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Location = new System.Drawing.Point(576, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Size = new System.Drawing.Size(334, 189);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.Location = new System.Drawing.Point(678, 397);
            this.btnSearchByID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(111, 26);
            this.btnSearchByID.TabIndex = 31;
            this.btnSearchByID.Text = "TÌM";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(576, 297);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 54);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(527, 398);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 25);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbSort
            // 
            this.cbSort.AutoCompleteCustomSource.AddRange(new string[] {
            "Họ và Tên",
            "Ngày sinh",
            "Ngày thuê",
            "Số điện thoại",
            "Lương",
            "Kinh nghiệm"});
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Họ và tên",
            "Ngày sinh",
            "Số điện thoại",
            "Hạng"});
            this.cbSort.Location = new System.Drawing.Point(166, 396);
            this.cbSort.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(126, 28);
            this.cbSort.TabIndex = 35;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 397);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "SẮP XẾP";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(799, 397);
            this.txtSearchByID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(111, 26);
            this.txtSearchByID.TabIndex = 37;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(347, 396);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 25);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "CHỈNH SỬA";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCustomerList";
            this.Size = new System.Drawing.Size(1045, 853);
            this.Load += new System.EventHandler(this.frmCustomerList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}