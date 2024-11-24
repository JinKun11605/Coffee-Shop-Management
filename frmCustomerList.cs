using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CoffeeShopManagement
{
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }
        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Cấu hình dgv
            //dgvCustomer.AutoGenerateColumns = false;


            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var baristaList = db.Customers
                .Select(e => new CustomerInfo
                {
                    FullName = e.FullName,
                    BirthDay = (DateTime)e.BirthDay,
                    PhoneNumber = e.PhoneNumber,
                    ID = e.CustomerID,
                    Password = e.Password,
                    CustomerLevel = e.CustomerLevel,
                })
                .ToList();
            dgvCustomer.DataSource = baristaList;

            // Cấu hình cbBox
            cbSort.SelectedIndex = 3;
        }
        private void Clear()
        {
            txtFullName.Clear();
            txtPassword.Clear();
            txtPhoneNumber.Clear();
            txtID.Clear();
            dtpBirthDay.Value = DateTime.Now;
            cbLevel.SelectedIndex = 0;
        }

        public void AddCustomer(CustomerInfo customerInfo)
        {
            Customer customer = new Customer
            {
                CustomerID = customerInfo.ID,
                Password = customerInfo.Password,
                CustomerLevel  = customerInfo.CustomerLevel,
                FullName = customerInfo.FullName,
                BirthDay = customerInfo.BirthDay,
                PhoneNumber = customerInfo.PhoneNumber,
            };

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            db.Customers.InsertOnSubmit(customer);
            db.SubmitChanges();

            MessageBox.Show("Thêm Khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(cbLevel.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            if (db.Customers.Any(c => c.CustomerID == txtID.Text))
            {
                MessageBox.Show("Tài khoản Khách hàng đã tồn tại, vui lòng đổi tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = txtID.Text;
            string password = txtPassword.Text;
            string fullName = txtFullName.Text;
            DateTime birthDay = dtpBirthDay.Value;
            string phoneNumber = txtPhoneNumber.Text;
            string customerLevel = cbLevel.Text;

            CustomerInfo customerInfo = new CustomerInfo(id, password, fullName, birthDay, phoneNumber, customerLevel);
            AddCustomer(customerInfo);
            LoadData();
            Clear();
        }

        private void dgvCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                cbLevel.Text = row.Cells["CustomerLevel"].Value.ToString();
                dtpBirthDay.Value = (DateTime)row.Cells["BirthDay"].Value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txtID.Text);

            if (customer == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            db.Customers.DeleteOnSubmit(customer);
            db.SubmitChanges();

            LoadData();
            Clear();
            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = (List<CustomerInfo>)dgvCustomer.DataSource;
            string optionSort = cbSort.Text;

            if (optionSort == "Họ và tên")
                dgvCustomer.DataSource = data.OrderBy(c => c.FullName).ToList();
            else if (optionSort == "Ngày sinh")
                dgvCustomer.DataSource = data.OrderBy(c => c.BirthDay).ToList();
            else if (optionSort == "Số điện thoại")
                dgvCustomer.DataSource = data.OrderBy(c => c.PhoneNumber).ToList();
            else if (optionSort == "Hạng")
                dgvCustomer.DataSource = data.OrderByDescending(c => c.CustomerLevel).ToList();
            else
                MessageBox.Show("Vui lòng chọn đúng điều kiện sắp xếp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchByID.Text))
            {
                MessageBox.Show("Vui lòng nhập Tài khoản cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = txtSearchByID.Text;

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();

            var customer = db.Customers
                .Where(u => u.CustomerID == id)
                .Select(u => new CustomerInfo
                {
                    FullName = u.FullName,
                    BirthDay = (DateTime)u.BirthDay,
                    PhoneNumber = u.PhoneNumber,
                    ID = u.CustomerID,
                    Password = u.Password,
                    CustomerLevel = u.CustomerLevel
                })
                .ToList();

            if (customer.Count == 0)
            {
                MessageBox.Show("Không tìm thấy Khách hàng với Tài khoản này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvCustomer.DataSource = customer;

            DataGridViewRow row = dgvCustomer.Rows[0];

            txtID.Text = row.Cells["ID"].Value.ToString();
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
            txtPassword.Text = row.Cells["Password"].Value.ToString();
            cbLevel.Text = row.Cells["CustomerLevel"].Value.ToString();
            dtpBirthDay.Value = (DateTime)row.Cells["BirthDay"].Value;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng điền tài khoản Khách hàng cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtPhoneNumber.Text) ||
                string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(cbLevel.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CoffeeShopDBDataContext db = new CoffeeShopDBDataContext();
            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == txtID.Text);

            if (customer == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            customer.FullName = txtFullName.Text;
            customer.BirthDay = dtpBirthDay.Value;
            customer.PhoneNumber = txtPhoneNumber.Text;
            customer.Password = txtPassword.Text;
            customer.CustomerLevel = cbLevel.Text;

            db.SubmitChanges();

            MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData();
            Clear();
        }
    }
}
