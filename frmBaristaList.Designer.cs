namespace CoffeeShopManagement
{
    partial class frmBaristaList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBarista = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpHireDay = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtYoE = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBarista = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBarista
            // 
            this.dgvBarista.AllowUserToAddRows = false;
            this.dgvBarista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBarista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.BirthDay,
            this.HireDay,
            this.PhoneNumber,
            this.Salary,
            this.YoE,
            this.ID,
            this.Password});
            this.dgvBarista.Location = new System.Drawing.Point(92, 537);
            this.dgvBarista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBarista.Name = "dgvBarista";
            this.dgvBarista.RowHeadersWidth = 51;
            this.dgvBarista.Size = new System.Drawing.Size(1070, 245);
            this.dgvBarista.TabIndex = 0;
            this.dgvBarista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarista_CellClick_1);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            dataGridViewCellStyle89.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FullName.DefaultCellStyle = dataGridViewCellStyle89;
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // BirthDay
            // 
            this.BirthDay.DataPropertyName = "BirthDay";
            dataGridViewCellStyle90.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BirthDay.DefaultCellStyle = dataGridViewCellStyle90;
            this.BirthDay.HeaderText = "Ngày sinh";
            this.BirthDay.MinimumWidth = 6;
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Width = 120;
            // 
            // HireDay
            // 
            this.HireDay.DataPropertyName = "HireDay";
            dataGridViewCellStyle91.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle91.Format = "dd/MM/yyyy";
            this.HireDay.DefaultCellStyle = dataGridViewCellStyle91;
            this.HireDay.HeaderText = "Ngày thuê";
            this.HireDay.MinimumWidth = 6;
            this.HireDay.Name = "HireDay";
            this.HireDay.Width = 120;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle92;
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 150;
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            dataGridViewCellStyle93.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Salary.DefaultCellStyle = dataGridViewCellStyle93;
            this.Salary.HeaderText = "Lương";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.Width = 125;
            // 
            // YoE
            // 
            this.YoE.DataPropertyName = "YoE";
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.YoE.DefaultCellStyle = dataGridViewCellStyle94;
            this.YoE.HeaderText = "Kinh nghiệm";
            this.YoE.MinimumWidth = 6;
            this.YoE.Name = "YoE";
            this.YoE.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle95.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle95;
            this.ID.HeaderText = "Tài khoản";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 120;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            dataGridViewCellStyle96.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Password.DefaultCellStyle = dataGridViewCellStyle96;
            this.Password.HeaderText = "Mật khẩu";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpHireDay);
            this.groupBox1.Controls.Add(this.dtpBirthDay);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtYoE);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(341, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(342, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN NHÂN VIÊN PHA CHẾ";
            // 
            // dtpHireDay
            // 
            this.dtpHireDay.CustomFormat = "dd/MM/yyyy";
            this.dtpHireDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHireDay.Location = new System.Drawing.Point(190, 122);
            this.dtpHireDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHireDay.Name = "dtpHireDay";
            this.dtpHireDay.ShowUpDown = true;
            this.dtpHireDay.Size = new System.Drawing.Size(100, 26);
            this.dtpHireDay.TabIndex = 24;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDay.Location = new System.Drawing.Point(190, 76);
            this.dtpBirthDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.ShowUpDown = true;
            this.dtpBirthDay.Size = new System.Drawing.Size(100, 26);
            this.dtpBirthDay.TabIndex = 23;
            this.dtpBirthDay.UseWaitCursor = true;
            this.dtpBirthDay.Value = new System.DateTime(2024, 11, 21, 0, 0, 0, 0);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(190, 219);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 26);
            this.txtSalary.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày thuê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lương";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(190, 36);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 26);
            this.txtFullName.TabIndex = 19;
            // 
            // txtYoE
            // 
            this.txtYoE.Location = new System.Drawing.Point(190, 268);
            this.txtYoE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYoE.Name = "txtYoE";
            this.txtYoE.Size = new System.Drawing.Size(100, 26);
            this.txtYoE.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(190, 178);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kinh nghiệm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(165, 126);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 26);
            this.txtPassword.TabIndex = 14;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(165, 66);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 26);
            this.txtID.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Location = new System.Drawing.Point(756, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(289, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByID.Location = new System.Drawing.Point(824, 401);
            this.btnSearchByID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(123, 28);
            this.btnSearchByID.TabIndex = 6;
            this.btnSearchByID.Text = "TÌM";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(756, 299);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(92, 288);
            this.btnAddPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(102, 24);
            this.btnAddPicture.TabIndex = 22;
            this.btnAddPicture.Text = "Thêm ảnh";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
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
            "Ngày thuê",
            "Số điện thoại",
            "Lương",
            "Kinh nghiệm"});
            this.cbSort.Location = new System.Drawing.Point(310, 401);
            this.cbSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(121, 28);
            this.cbSort.TabIndex = 23;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "SẮP XẾP";
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Location = new System.Drawing.Point(969, 404);
            this.txtSearchByID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(121, 26);
            this.txtSearchByID.TabIndex = 25;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(480, 401);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 28);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "CHỈNH SỬA";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(652, 401);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 28);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBarista
            // 
            this.pictureBarista.Location = new System.Drawing.Point(78, 71);
            this.pictureBarista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBarista.Name = "pictureBarista";
            this.pictureBarista.Size = new System.Drawing.Size(142, 185);
            this.pictureBarista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBarista.TabIndex = 21;
            this.pictureBarista.TabStop = false;
            // 
            // frmBaristaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearchByID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pictureBarista);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvBarista);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaristaList";
            this.Size = new System.Drawing.Size(1252, 831);
            this.Load += new System.EventHandler(this.frmBaristaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBarista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBarista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBarista;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn YoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtYoE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHireDay;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}