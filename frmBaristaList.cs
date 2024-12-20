﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class frmBaristaList : UserControl
    {
        public frmBaristaList()
        {
            InitializeComponent();
        }
        private void frmBaristaList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Cấu hình dgv
            dgvBarista.AutoGenerateColumns = false;


            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var baristaList = db.Baristas
                .Select(e => new BaristaInfo
                {
                    FullName = e.FullName,
                    BirthDay = e.BirthDay,
                    HireDay = e.HireDay,
                    PhoneNumber = e.PhoneNumber,
                    Salary = e.Salary,
                    ID = e.BaristaID,
                    Password = e.Password,
                    YoE = e.YoE
                })
                .ToList();
            dgvBarista.DataSource = baristaList;

            // Cấu hình cbBox
            cbSort.SelectedIndex = 5;
        }
        private void Clear()
        {
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhoneNumber.Clear();
            txtID.Clear();
            txtYoE.Clear();
            txtSalary.Clear();
            dtpBirthDay.Value = DateTime.Now;
            dtpHireDay.Value = DateTime.Now;
            pictureBarista.Image = null;
        }
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại chọn file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Chọn ảnh nhân viên";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh trong PictureBox
                pictureBarista.Image = Image.FromFile(openFileDialog.FileName);
                pictureBarista.SizeMode = PictureBoxSizeMode.StretchImage; // Hiển thị ảnh vừa khung
            }

        }
        private byte[] ConvertImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();

            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public void AddBarista(BaristaInfo baristaInfo)
        {
            Barista barista = new Barista
            {
                BaristaID = baristaInfo.ID,
                Password = baristaInfo.Password,
                FullName = baristaInfo.FullName,
                BirthDay = baristaInfo.BirthDay,
                PhoneNumber = baristaInfo.PhoneNumber,
                HireDay = baristaInfo.HireDay,
                YoE = baristaInfo.YoE,
                Salary = baristaInfo.Salary,
                Image = ConvertImageToByteArray(pictureBarista)
            };

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            db.Baristas.InsertOnSubmit(barista);
            db.SubmitChanges();

            MessageBox.Show("Thêm Barista thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtSalary.Text) ||
                string.IsNullOrEmpty(txtYoE.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yoE;
            if (!int.TryParse(txtYoE.Text, out yoE))
            {
                MessageBox.Show("Kinh nghiệm phải là một số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = txtID.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            DateTime birthDay = dtpBirthDay.Value;
            DateTime hireDay = dtpHireDay.Value;
            string phoneNumber = txtPhoneNumber.Text;
            decimal salary = decimal.Parse(txtSalary.Text);
            byte[] image;

            if (pictureBarista.Image != null) 
                image = ConvertImageToByteArray(pictureBarista);
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem ID đã tồn tại chứa <= ID là khóa chính
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            if (db.Baristas.Where(em => em.BaristaID == id).Any())
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng đổi tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BaristaInfo baristaInfo  = new BaristaInfo(id, password, fullName, birthDay, phoneNumber, hireDay, yoE, salary);
            AddBarista(baristaInfo);

            LoadData();
            Clear();
        }
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = (List<BaristaInfo>)dgvBarista.DataSource;
            string optionSort = cbSort.Text;

            if (optionSort == "Họ và tên")
                dgvBarista.DataSource = data.OrderBy(b => b.FullName).ToList();
            else if (optionSort == "Ngày sinh")
                dgvBarista.DataSource = data.OrderBy(b => b.BirthDay).ToList();
            else if (optionSort == "Ngày thuê")
                dgvBarista.DataSource = data.OrderBy(b => b.HireDay).ToList();
            else if (optionSort == "Lương")
                dgvBarista.DataSource = data.OrderByDescending(b => b.Salary).ToList();
            else if (optionSort == "Số điện thoại")
                dgvBarista.DataSource = data.OrderBy(b => b.PhoneNumber).ToList();
            else if (optionSort == "Kinh nghiệm")
                dgvBarista.DataSource = data.OrderByDescending(b => b.YoE).ToList();
            else
                MessageBox.Show("Vui lòng chọn đúng điều kiện!");
        }
        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByID.Text))
            {
                MessageBox.Show("Vui lòng nhập Tài khoản cần tìm.");
                return;
            }

            string id = txtSearchByID.Text;

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var barista = db.Baristas
                .Where(u => u.BaristaID == id)
                .Select(u => new BaristaInfo
                {
                    FullName = u.FullName,
                    BirthDay = u.BirthDay,
                    HireDay = u.HireDay,
                    PhoneNumber = u.PhoneNumber,
                    Salary = u.Salary,
                    ID = u.BaristaID,
                    Password = u.Password,
                    YoE = u.YoE
                })
                .ToList();

            if (barista.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên pha chế với Tài khoản này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvBarista.DataSource = barista;

            // In ra giao diện
            DataGridViewRow row = dgvBarista.Rows[0];

            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtID.Text = row.Cells["ID"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
            txtYoE.Text = row.Cells["YoE"].Value.ToString();
            txtSalary.Text = row.Cells["Salary"].Value.ToString();
            txtPassword.Text = row.Cells["Password"].Value.ToString();
            dtpBirthDay.Value = (DateTime)row.Cells["BirthDay"].Value;
            dtpHireDay.Value = (DateTime)row.Cells["HireDay"].Value;

            CoffeeShopDBDataContext db2 = new CoffeeShopDBDataContext();
            Barista barista2 = db.Baristas.FirstOrDefault(em => em.BaristaID == txtID.Text);

            if (barista2.Image == null)
            {
                pictureBarista.Image = null;
                return;
            }

            try
            {
                MemoryStream ms = new MemoryStream(barista2.Image.ToArray());
                pictureBarista.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtSalary.Text) ||
                string.IsNullOrEmpty(txtYoE.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int yoE;
            if (!int.TryParse(txtYoE.Text, out yoE))
            {
                MessageBox.Show("Kinh nghiệm phải là một số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] image;
            if (pictureBarista.Image != null)
                image = ConvertImageToByteArray(pictureBarista);
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = txtID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui lòng điền Tài khoản nhân viên cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }            

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            var barista = db.Baristas.FirstOrDefault(em => em.BaristaID == id);

            if (barista == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên Pha chế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            barista.FullName = txtFullName.Text;
            barista.BirthDay = dtpBirthDay.Value;
            barista.HireDay = dtpHireDay.Value;
            barista.PhoneNumber = txtPhoneNumber.Text;
            barista.YoE = yoE;
            barista.Salary = decimal.Parse(txtSalary.Text);
            barista.Password = txtPassword.Text;
            barista.Image = image;


            db.SubmitChanges();

            MessageBox.Show("Cập nhật thông tin nhân viên Pha chế thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LoadData();            
        }
        private void dgvBarista_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {    
                DataGridViewRow row = dgvBarista.Rows[e.RowIndex];

                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtYoE.Text = row.Cells["YoE"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                dtpBirthDay.Value = (DateTime)row.Cells["BirthDay"].Value;
                dtpHireDay.Value = (DateTime)row.Cells["HireDay"].Value;
            }

            string id = txtID.Text;
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            Barista barista = db.Baristas.FirstOrDefault(em => em.BaristaID == id);

            if (barista.Image == null)
            {
                pictureBarista.Image = null; 
                return;
            }

            try
            {
                MemoryStream ms = new MemoryStream(barista.Image.ToArray());
                pictureBarista.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng điền Tài khoản nhân viên Pha chế cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            var barista = db.Baristas.FirstOrDefault(em => em.BaristaID == txtID.Text);

            if (barista == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên Pha chế để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.Baristas.DeleteOnSubmit(barista);
            db.SubmitChanges();
            LoadData();
            Clear();

            MessageBox.Show("Đã xóa nhân viên Pha chế thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
